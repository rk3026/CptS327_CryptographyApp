namespace CryptographyApp
{
    partial class FileEncryptionTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileEncryptionTab));
            label3 = new Label();
            label1 = new Label();
            buttonExportPublicKey = new Button();
            buttonImportPublicKey = new Button();
            buttonCreateAsmKeys = new Button();
            buttonGetPrivateKey = new Button();
            buttonDecryptFile = new Button();
            buttonEncryptFile = new Button();
            _encryptOpenFileDialog = new OpenFileDialog();
            _decryptOpenFileDialog = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 40);
            label3.TabIndex = 16;
            label3.Text = "Current PublicKey:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 40);
            label1.TabIndex = 15;
            label1.Text = "PublicKey not set";
            // 
            // buttonExportPublicKey
            // 
            buttonExportPublicKey.Dock = DockStyle.Fill;
            buttonExportPublicKey.Location = new Point(3, 71);
            buttonExportPublicKey.Name = "buttonExportPublicKey";
            buttonExportPublicKey.Size = new Size(120, 62);
            buttonExportPublicKey.TabIndex = 12;
            buttonExportPublicKey.Text = "Export Public PublicKey";
            buttonExportPublicKey.UseVisualStyleBackColor = true;
            buttonExportPublicKey.Click += buttonExportPublicKey_Click;
            // 
            // buttonImportPublicKey
            // 
            buttonImportPublicKey.Dock = DockStyle.Fill;
            buttonImportPublicKey.Location = new Point(3, 139);
            buttonImportPublicKey.Name = "buttonImportPublicKey";
            buttonImportPublicKey.Size = new Size(120, 62);
            buttonImportPublicKey.TabIndex = 13;
            buttonImportPublicKey.Text = "Import Public PublicKey";
            buttonImportPublicKey.UseVisualStyleBackColor = true;
            buttonImportPublicKey.Click += buttonImportPublicKey_Click;
            // 
            // buttonCreateAsmKeys
            // 
            buttonCreateAsmKeys.Dock = DockStyle.Fill;
            buttonCreateAsmKeys.Location = new Point(3, 3);
            buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            buttonCreateAsmKeys.Size = new Size(120, 62);
            buttonCreateAsmKeys.TabIndex = 11;
            buttonCreateAsmKeys.Text = "Create Asm Keys";
            buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            buttonCreateAsmKeys.Click += buttonCreateAsmKeys_Click;
            // 
            // buttonGetPrivateKey
            // 
            buttonGetPrivateKey.Dock = DockStyle.Fill;
            buttonGetPrivateKey.Location = new Point(3, 343);
            buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            buttonGetPrivateKey.Size = new Size(120, 65);
            buttonGetPrivateKey.TabIndex = 14;
            buttonGetPrivateKey.Text = "Get Private PublicKey";
            buttonGetPrivateKey.UseVisualStyleBackColor = true;
            buttonGetPrivateKey.Click += buttonGetPrivateKey_Click;
            // 
            // buttonDecryptFile
            // 
            buttonDecryptFile.Dock = DockStyle.Fill;
            buttonDecryptFile.Location = new Point(3, 275);
            buttonDecryptFile.Name = "buttonDecryptFile";
            buttonDecryptFile.Size = new Size(120, 62);
            buttonDecryptFile.TabIndex = 10;
            buttonDecryptFile.Text = "Decrypt File";
            buttonDecryptFile.UseVisualStyleBackColor = true;
            buttonDecryptFile.Click += buttonDecryptFile_Click;
            // 
            // buttonEncryptFile
            // 
            buttonEncryptFile.Dock = DockStyle.Fill;
            buttonEncryptFile.Location = new Point(3, 207);
            buttonEncryptFile.Name = "buttonEncryptFile";
            buttonEncryptFile.Size = new Size(120, 62);
            buttonEncryptFile.TabIndex = 9;
            buttonEncryptFile.Text = "Encrypt File\t";
            buttonEncryptFile.UseVisualStyleBackColor = true;
            buttonEncryptFile.Click += buttonEncryptFile_Click;
            // 
            // _encryptOpenFileDialog
            // 
            _encryptOpenFileDialog.FileName = "openFileDialog1";
            // 
            // _decryptOpenFileDialog
            // 
            _decryptOpenFileDialog.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(richTextBox1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(792, 417);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(buttonGetPrivateKey, 0, 5);
            tableLayoutPanel2.Controls.Add(buttonDecryptFile, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonEncryptFile, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonExportPublicKey, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonCreateAsmKeys, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonImportPublicKey, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(379, 411);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(408, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(381, 411);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // FileEncryptionTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FileEncryptionTab";
            Size = new Size(792, 417);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label1;
        private Button buttonExportPublicKey;
        private Button buttonImportPublicKey;
        private Button buttonCreateAsmKeys;
        private Button buttonGetPrivateKey;
        private Button buttonDecryptFile;
        private Button buttonEncryptFile;
        private OpenFileDialog _encryptOpenFileDialog;
        private OpenFileDialog _decryptOpenFileDialog;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox richTextBox1;
    }
}
