namespace V4C_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uploadFileToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPgFile = new System.Windows.Forms.TabPage();
            this.txtBoxFileContent = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPgFTP = new System.Windows.Forms.TabPage();
            this.txtBoxFTPContent = new System.Windows.Forms.TextBox();
            this.gBoxFileCtrls = new System.Windows.Forms.GroupBox();
            this.btnDownloadToComp = new System.Windows.Forms.Button();
            this.btnDoneEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFTPDownload = new System.Windows.Forms.Button();
            this.treeViewFTP = new System.Windows.Forms.TreeView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timerFTP = new System.Windows.Forms.Timer(this.components);
            this.LblContentFTP = new System.Windows.Forms.Label();
            this.txtBoxFTPTitle = new System.Windows.Forms.TextBox();
            this.LblTitleFTP = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tabPgFile.SuspendLayout();
            this.tabPgFTP.SuspendLayout();
            this.gBoxFileCtrls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.uploadFileToServerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.toolsToolStripMenuItem.Text = "&FTP";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.customizeToolStripMenuItem.Text = "New Connection";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.optionsToolStripMenuItem.Text = "Disconnect";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // uploadFileToServerToolStripMenuItem
            // 
            this.uploadFileToServerToolStripMenuItem.Enabled = false;
            this.uploadFileToServerToolStripMenuItem.Name = "uploadFileToServerToolStripMenuItem";
            this.uploadFileToServerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.uploadFileToServerToolStripMenuItem.Text = "Upload File";
            this.uploadFileToServerToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToServerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPgFile);
            this.tabCtrl.Controls.Add(this.tabPgFTP);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(0, 24);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(784, 537);
            this.tabCtrl.TabIndex = 1;
            // 
            // tabPgFile
            // 
            this.tabPgFile.Controls.Add(this.txtBoxFileContent);
            this.tabPgFile.Controls.Add(this.txtBoxTitle);
            this.tabPgFile.Controls.Add(this.lblContent);
            this.tabPgFile.Controls.Add(this.lblTitle);
            this.tabPgFile.Location = new System.Drawing.Point(4, 22);
            this.tabPgFile.Name = "tabPgFile";
            this.tabPgFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgFile.Size = new System.Drawing.Size(776, 511);
            this.tabPgFile.TabIndex = 0;
            this.tabPgFile.Text = "New File";
            this.tabPgFile.UseVisualStyleBackColor = true;
            // 
            // txtBoxFileContent
            // 
            this.txtBoxFileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFileContent.Location = new System.Drawing.Point(6, 61);
            this.txtBoxFileContent.Multiline = true;
            this.txtBoxFileContent.Name = "txtBoxFileContent";
            this.txtBoxFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxFileContent.Size = new System.Drawing.Size(762, 442);
            this.txtBoxFileContent.TabIndex = 2;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTitle.Location = new System.Drawing.Point(86, 6);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(682, 26);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(6, 38);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(74, 20);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "Content: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title: ";
            // 
            // tabPgFTP
            // 
            this.tabPgFTP.Controls.Add(this.txtBoxFTPTitle);
            this.tabPgFTP.Controls.Add(this.LblTitleFTP);
            this.tabPgFTP.Controls.Add(this.LblContentFTP);
            this.tabPgFTP.Controls.Add(this.txtBoxFTPContent);
            this.tabPgFTP.Controls.Add(this.gBoxFileCtrls);
            this.tabPgFTP.Controls.Add(this.treeViewFTP);
            this.tabPgFTP.Location = new System.Drawing.Point(4, 22);
            this.tabPgFTP.Name = "tabPgFTP";
            this.tabPgFTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgFTP.Size = new System.Drawing.Size(776, 511);
            this.tabPgFTP.TabIndex = 1;
            this.tabPgFTP.Text = "FTP Connection";
            this.tabPgFTP.UseVisualStyleBackColor = true;
            // 
            // txtBoxFTPContent
            // 
            this.txtBoxFTPContent.AcceptsReturn = true;
            this.txtBoxFTPContent.AcceptsTab = true;
            this.txtBoxFTPContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFTPContent.Location = new System.Drawing.Point(206, 55);
            this.txtBoxFTPContent.Multiline = true;
            this.txtBoxFTPContent.Name = "txtBoxFTPContent";
            this.txtBoxFTPContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxFTPContent.Size = new System.Drawing.Size(562, 389);
            this.txtBoxFTPContent.TabIndex = 3;
            // 
            // gBoxFileCtrls
            // 
            this.gBoxFileCtrls.Controls.Add(this.btnDownloadToComp);
            this.gBoxFileCtrls.Controls.Add(this.btnDoneEdit);
            this.gBoxFileCtrls.Controls.Add(this.btnDelete);
            this.gBoxFileCtrls.Controls.Add(this.btnFTPDownload);
            this.gBoxFileCtrls.Location = new System.Drawing.Point(206, 450);
            this.gBoxFileCtrls.Name = "gBoxFileCtrls";
            this.gBoxFileCtrls.Size = new System.Drawing.Size(562, 53);
            this.gBoxFileCtrls.TabIndex = 2;
            this.gBoxFileCtrls.TabStop = false;
            this.gBoxFileCtrls.Text = "File Controls";
            // 
            // btnDownloadToComp
            // 
            this.btnDownloadToComp.Location = new System.Drawing.Point(313, 19);
            this.btnDownloadToComp.Name = "btnDownloadToComp";
            this.btnDownloadToComp.Size = new System.Drawing.Size(130, 23);
            this.btnDownloadToComp.TabIndex = 4;
            this.btnDownloadToComp.Text = "Download to Computer";
            this.btnDownloadToComp.UseVisualStyleBackColor = true;
            this.btnDownloadToComp.Click += new System.EventHandler(this.btnDownloadToComp_Click);
            // 
            // btnDoneEdit
            // 
            this.btnDoneEdit.Location = new System.Drawing.Point(119, 19);
            this.btnDoneEdit.Name = "btnDoneEdit";
            this.btnDoneEdit.Size = new System.Drawing.Size(107, 23);
            this.btnDoneEdit.TabIndex = 3;
            this.btnDoneEdit.Text = "Done Editing";
            this.btnDoneEdit.UseVisualStyleBackColor = true;
            this.btnDoneEdit.Click += new System.EventHandler(this.btnDoneEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(449, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete File";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFTPDownload
            // 
            this.btnFTPDownload.Location = new System.Drawing.Point(6, 19);
            this.btnFTPDownload.Name = "btnFTPDownload";
            this.btnFTPDownload.Size = new System.Drawing.Size(107, 23);
            this.btnFTPDownload.TabIndex = 0;
            this.btnFTPDownload.Text = "Download and Edit";
            this.btnFTPDownload.UseVisualStyleBackColor = true;
            this.btnFTPDownload.Click += new System.EventHandler(this.btnFTPDownload_Click);
            // 
            // treeViewFTP
            // 
            this.treeViewFTP.Location = new System.Drawing.Point(8, 6);
            this.treeViewFTP.Name = "treeViewFTP";
            this.treeViewFTP.Size = new System.Drawing.Size(192, 497);
            this.treeViewFTP.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // timerFTP
            // 
            this.timerFTP.Tick += new System.EventHandler(this.timerFTP_Tick);
            // 
            // LblContentFTP
            // 
            this.LblContentFTP.AutoSize = true;
            this.LblContentFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContentFTP.Location = new System.Drawing.Point(206, 32);
            this.LblContentFTP.Name = "LblContentFTP";
            this.LblContentFTP.Size = new System.Drawing.Size(74, 20);
            this.LblContentFTP.TabIndex = 4;
            this.LblContentFTP.Text = "Content: ";
            // 
            // txtBoxFTPTitle
            // 
            this.txtBoxFTPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFTPTitle.Location = new System.Drawing.Point(258, 3);
            this.txtBoxFTPTitle.Name = "txtBoxFTPTitle";
            this.txtBoxFTPTitle.Size = new System.Drawing.Size(510, 26);
            this.txtBoxFTPTitle.TabIndex = 6;
            // 
            // LblTitleFTP
            // 
            this.LblTitleFTP.AutoSize = true;
            this.LblTitleFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleFTP.Location = new System.Drawing.Point(206, 6);
            this.LblTitleFTP.Name = "LblTitleFTP";
            this.LblTitleFTP.Size = new System.Drawing.Size(46, 20);
            this.LblTitleFTP.TabIndex = 5;
            this.LblTitleFTP.Text = "Title: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "V4C | Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            this.tabPgFile.ResumeLayout(false);
            this.tabPgFile.PerformLayout();
            this.tabPgFTP.ResumeLayout(false);
            this.tabPgFTP.PerformLayout();
            this.gBoxFileCtrls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPgFile;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tabPgFTP;
        private System.Windows.Forms.GroupBox gBoxFileCtrls;
        private System.Windows.Forms.TreeView treeViewFTP;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFTPDownload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer timerFTP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToServerToolStripMenuItem;
        private System.Windows.Forms.Button btnDownloadToComp;
        private System.Windows.Forms.Button btnDoneEdit;
        private System.Windows.Forms.TextBox txtBoxFileContent;
        private System.Windows.Forms.TextBox txtBoxFTPContent;
        private System.Windows.Forms.Label LblContentFTP;
        private System.Windows.Forms.TextBox txtBoxFTPTitle;
        private System.Windows.Forms.Label LblTitleFTP;
    }
}

