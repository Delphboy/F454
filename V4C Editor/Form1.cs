using System;
using System.Windows.Forms;

using System.Xml; //used for the XML node list returned by the 

namespace V4C_Editor
{
    public partial class Form1 : Form
    {
        //variables
        private XML xml = new XML();

        private bool isFileOpen = false;
        private bool isTreeBuilt = false;

        private string fileLocation = "";
        private string tempTitle = "";                  //used to check if file is saved on exit
        private string tempDescription = "";            //used to check if file is saved on exit

        //***************

        public Form1()
        {
            InitializeComponent();
        }

        //load form -> call setup
        private void Form1_Load(object sender, EventArgs e)
        {
            setup();
        }

        //form closed -> call exitProgramme
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitProgramme();
        }

        //setup the environment
        public void setup()
        {
            enableEditor(false);
            enableFTPEditor(false);

            //setup menu strip
            saveAsToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;

            //setup timer
            timerFTP.Interval = 100;
            timerFTP.Enabled = true;
            timerFTP.Start();
        }

        //--------MENU STRIP--------//
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Open File
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDiag();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitProgramme();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Undo
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: ReDO
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Cut
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Copy
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Paste
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Select all
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Henry Senior for Vision4Children" + Environment.NewLine + "Version: 1.0.0");
        }

        //FTP Timer
        private void timerFTP_Tick(object sender, EventArgs e)
        {
            if (FTP.isConnected == true)
            {
                FTPUpdate();
            }
        }

        //Establish FTP Connection
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTPSettings FtpSetForm = new FTPSettings();
            FtpSetForm.Show();
        }

        //Disconnet FTP Connection
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTP.disconnect();
            FTPUpdate();
            treeViewFTP.Nodes.Clear(); //clear tree view
        }

        //Upload
        private void uploadFileToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uploadFile();
        }

        //check if saved, then exit
        private void exitProgramme()
        {
            if (isFileOpen == true)
            {
                if (isMostRecentSaved() == false)
                {
                    DialogResult res = MessageBox.Show("Would you like to save your work", "Save your work", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        saveFile();
                    }
                }
            }
            timerFTP.Enabled = false;
            timerFTP.Dispose();
            Environment.Exit(100);
        }

        //check the saved file = file data in form
        public bool isMostRecentSaved()
        {
            return (tempTitle == txtBoxTitle.Text && tempDescription == txtBoxFileContent.Text);
        }

        //lock or unlock editor (true = enabled | false = disabled)
        public void enableEditor(bool lockKey)
        {
            txtBoxFileContent.ReadOnly = !lockKey;
            txtBoxTitle.ReadOnly = !lockKey;
            saveAsToolStripMenuItem.Enabled = lockKey;
            saveToolStripMenuItem.Enabled = lockKey;
        }

        //lock or unlock FTP file controls (true = enabled | false = disabled)
        public void enableFTPEditor(bool lockKey)
        {
            treeViewFTP.Enabled = lockKey;
            txtBoxFTPContent.ReadOnly = !lockKey;
            txtBoxFTPTitle.ReadOnly = !lockKey;
            gBoxFileCtrls.Enabled = lockKey;
            uploadFileToServerToolStripMenuItem.Enabled = lockKey;
            if (lockKey == false)
                txtBoxFTPContent.Text = "Please connect to an FTP server and select a file to edit";
        }

        //Update things that rely on the FTP connection
        public void FTPUpdate()
        {
            enableFTPEditor(FTP.isConnected);
            if (isTreeBuilt == false)
            {
                buildFileTree();
                isTreeBuilt = true;
            }
        }

        //new file
        public void newFile()
        {
            saveDiag();
            isFileOpen = true;
            enableEditor(true);
        }

        //save diaglog code
        public void saveDiag()
        {
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    fileLocation = saveFileDialog.FileName;
                    saveFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            tabPgFile.Text = System.IO.Path.GetFileName(saveFileDialog.FileName);
        }

        //save file
        public void saveFile()
        {
            xml.write(fileLocation, txtBoxTitle.Text, txtBoxFileContent.Text);
            tempTitle = txtBoxTitle.Text;
            tempDescription = txtBoxFileContent.Text;
        }

        //open file
        public void uploadFile()
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    Console.WriteLine(openFileDialog.FileName);
                    FTP.uploadFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            isTreeBuilt = false;
            buildFileTree(); //update tree
            isTreeBuilt = true;
        }

        //-----FTP CONTROLS-----//
        //Download file
        private void btnFTPDownload_Click(object sender, EventArgs e)
        {
            string XMLString;
            XmlNodeList xmlList;

            XMLString = FTP.downloadFile(treeViewFTP.SelectedNode.Text);
            xmlList = xml.splitXML(XMLString, XML.XMLTag.Description);

            for (int i = 0; i < xmlList.Count; i++)
            {
                txtBoxFTPContent.Text = xmlList[i].InnerXml;
            }

            xmlList = null;
            xmlList = xml.splitXML(XMLString, XML.XMLTag.Title);

            for (int i = 0; i < xmlList.Count; i++)
            {
                txtBoxFTPTitle.Text = xmlList[i].InnerXml;
            }

            tabPgFTP.Text = "FTP Connection | " + treeViewFTP.SelectedNode.Text;
        }

        //Delete file from server
        private void btnDelete_Click(object sender, EventArgs e)
        {
            FTP.deleteFile(treeViewFTP.SelectedNode.Text);
            buildFileTree();
        }

        //Reupload file to server post edit
        private void btnDoneEdit_Click(object sender, EventArgs e)
        {
            string XMLString;
            XmlDocument xmlDoc;

            xmlDoc = new XmlDocument();
            xmlDoc.CreateElement("Title", txtBoxFTPTitle.Text);
            xmlDoc.CreateElement("Description", txtBoxFTPContent.Text);

            XMLString = xmlDoc.ToString();

            MessageBox.Show(XMLString);
            //FTP.doneEditing(treeViewFTP.SelectedNode.Text, XMLString);
        }

        private void btnDownloadToComp_Click(object sender, EventArgs e)
        {
            //TOOD: Download to computer
            MessageBox.Show(treeViewFTP.SelectedNode.Name.ToString());
        }

        public void buildFileTree()
        {
            isTreeBuilt = false;

            FTP.buildTree();

            treeViewFTP.BeginUpdate();
            treeViewFTP.Nodes.Clear(); //reset nodes

            treeViewFTP.Nodes.Add(FTP.host);

            for (int i = 0; i < FTP.directories.Count; i++)
            {
                treeViewFTP.Nodes[0].Nodes.Add(FTP.directories[i]);
            }

            treeViewFTP.EndUpdate();
            isTreeBuilt = true;
        }

        public void updateTree()
        {
            isTreeBuilt = false;

            FTP.directories.Clear();
            treeViewFTP.Enabled = true;
            treeViewFTP.Nodes.Clear(); //reset nodes
            buildFileTree();

            isTreeBuilt = true;
        }

    }
}