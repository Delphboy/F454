using System;
using System.Windows.Forms;

namespace V4C_Editor
{
    public partial class FTPSettings : Form
    {
        public FTPSettings()
        {
            InitializeComponent();
        }

        //load form
        private void FTPSettings_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Set back to text box input

            //FTP.host = txtBoxHost.Text;
            //FTP.directory = txtBoxDir.Text;
            //FTP.username = txtBoxUsername.Text;
            //FTP.password = txtBoxPassword.Text;

            FTP.host = "ftp.ayatronstudios.com";
            FTP.directory = "Roku/xml/";
            FTP.username = "roku@ayatronstudios.com";
            FTP.password = "Roku3v4c";

            string msg = FTP.connect();
            if (msg != "")
            {
                MessageBox.Show(msg);
                FTP.isConnected = false;
            }
            else
            {
                FTP.isConnected = true;
                Close();
            }
        }
    }
}