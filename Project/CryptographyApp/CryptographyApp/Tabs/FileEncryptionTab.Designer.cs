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
            richTextBox1 = new RichTextBox();
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
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(420, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(338, 297);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 82);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 16;
            label3.Text = "Current PublicKey:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 82);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 15;
            label1.Text = "PublicKey not set";
            // 
            // buttonExportPublicKey
            // 
            buttonExportPublicKey.Location = new Point(31, 130);
            buttonExportPublicKey.Name = "buttonExportPublicKey";
            buttonExportPublicKey.Size = new Size(154, 29);
            buttonExportPublicKey.TabIndex = 12;
            buttonExportPublicKey.Text = "Export Public PublicKey";
            buttonExportPublicKey.UseVisualStyleBackColor = true;
            // 
            // buttonImportPublicKey
            // 
            buttonImportPublicKey.Location = new Point(284, 224);
            buttonImportPublicKey.Name = "buttonImportPublicKey";
            buttonImportPublicKey.Size = new Size(142, 29);
            buttonImportPublicKey.TabIndex = 13;
            buttonImportPublicKey.Text = "Import Public PublicKey";
            buttonImportPublicKey.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAsmKeys
            // 
            buttonCreateAsmKeys.Location = new Point(31, 78);
            buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            buttonCreateAsmKeys.Size = new Size(154, 29);
            buttonCreateAsmKeys.TabIndex = 11;
            buttonCreateAsmKeys.Text = "Create Asm Keys";
            buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            // 
            // buttonGetPrivateKey
            // 
            buttonGetPrivateKey.Location = new Point(288, 294);
            buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            buttonGetPrivateKey.Size = new Size(133, 29);
            buttonGetPrivateKey.TabIndex = 14;
            buttonGetPrivateKey.Text = "Get Private PublicKey";
            buttonGetPrivateKey.UseVisualStyleBackColor = true;
            // 
            // buttonDecryptFile
            // 
            buttonDecryptFile.Location = new Point(31, 224);
            buttonDecryptFile.Name = "buttonDecryptFile";
            buttonDecryptFile.Size = new Size(154, 29);
            buttonDecryptFile.TabIndex = 10;
            buttonDecryptFile.Text = "Decrypt File";
            buttonDecryptFile.UseVisualStyleBackColor = true;
            // 
            // buttonEncryptFile
            // 
            buttonEncryptFile.Location = new Point(31, 176);
            buttonEncryptFile.Name = "buttonEncryptFile";
            buttonEncryptFile.Size = new Size(154, 29);
            buttonEncryptFile.TabIndex = 9;
            buttonEncryptFile.Text = "Encrypt File\t";
            buttonEncryptFile.UseVisualStyleBackColor = true;
            // 
            // _encryptOpenFileDialog
            // 
            _encryptOpenFileDialog.FileName = "openFileDialog1";
            // 
            // _decryptOpenFileDialog
            // 
            _decryptOpenFileDialog.FileName = "openFileDialog1";
            // 
            // FileEncryptionTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonExportPublicKey);
            Controls.Add(buttonImportPublicKey);
            Controls.Add(buttonCreateAsmKeys);
            Controls.Add(buttonGetPrivateKey);
            Controls.Add(buttonDecryptFile);
            Controls.Add(buttonEncryptFile);
            Name = "FileEncryptionTab";
            Size = new Size(792, 417);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
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
    }
}
