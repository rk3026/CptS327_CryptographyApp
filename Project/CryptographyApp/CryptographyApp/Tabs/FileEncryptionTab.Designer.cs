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
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(207, 22);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 16;
            label3.Text = "Current PublicKey:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(392, 22);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 15;
            label1.Text = "PublicKey not set";
            // 
            // buttonExportPublicKey
            // 
            buttonExportPublicKey.Dock = DockStyle.Fill;
            buttonExportPublicKey.Location = new Point(3, 68);
            buttonExportPublicKey.Name = "buttonExportPublicKey";
            buttonExportPublicKey.Size = new Size(175, 59);
            buttonExportPublicKey.TabIndex = 12;
            buttonExportPublicKey.Text = "Export Public PublicKey";
            buttonExportPublicKey.UseVisualStyleBackColor = true;
            buttonExportPublicKey.Click += buttonExportPublicKey_Click;
            // 
            // buttonImportPublicKey
            // 
            buttonImportPublicKey.Dock = DockStyle.Fill;
            buttonImportPublicKey.Location = new Point(3, 133);
            buttonImportPublicKey.Name = "buttonImportPublicKey";
            buttonImportPublicKey.Size = new Size(175, 59);
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
            buttonCreateAsmKeys.Size = new Size(175, 59);
            buttonCreateAsmKeys.TabIndex = 11;
            buttonCreateAsmKeys.Text = "Create Asm Keys";
            buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            buttonCreateAsmKeys.Click += buttonCreateAsmKeys_Click;
            // 
            // buttonGetPrivateKey
            // 
            buttonGetPrivateKey.Dock = DockStyle.Fill;
            buttonGetPrivateKey.Location = new Point(3, 328);
            buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            buttonGetPrivateKey.Size = new Size(175, 60);
            buttonGetPrivateKey.TabIndex = 14;
            buttonGetPrivateKey.Text = "Get Private PublicKey";
            buttonGetPrivateKey.UseVisualStyleBackColor = true;
            buttonGetPrivateKey.Click += buttonGetPrivateKey_Click;
            // 
            // buttonDecryptFile
            // 
            buttonDecryptFile.Dock = DockStyle.Fill;
            buttonDecryptFile.Location = new Point(3, 263);
            buttonDecryptFile.Name = "buttonDecryptFile";
            buttonDecryptFile.Size = new Size(175, 59);
            buttonDecryptFile.TabIndex = 10;
            buttonDecryptFile.Text = "Decrypt File";
            buttonDecryptFile.UseVisualStyleBackColor = true;
            buttonDecryptFile.Click += buttonDecryptFile_Click;
            // 
            // buttonEncryptFile
            // 
            buttonEncryptFile.Dock = DockStyle.Fill;
            buttonEncryptFile.Location = new Point(3, 198);
            buttonEncryptFile.Name = "buttonEncryptFile";
            buttonEncryptFile.Size = new Size(175, 59);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(792, 417);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
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
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(545, 391);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(186, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 19;
            label2.Text = "File Encryption Using RSA";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.ControlLight;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 1);
            tableLayoutPanel3.Controls.Add(label7, 0, 2);
            tableLayoutPanel3.Controls.Add(label8, 0, 3);
            tableLayoutPanel3.Controls.Add(label9, 0, 4);
            tableLayoutPanel3.Controls.Add(label10, 0, 5);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(574, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.Size = new Size(215, 391);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(190, 40);
            label5.TabIndex = 18;
            label5.Text = "1) Click Create Asymmetric Keys";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 65);
            label6.Name = "label6";
            label6.Size = new Size(205, 65);
            label6.TabIndex = 19;
            label6.Text = "2) Click the Export Public Key button. Note that exporting the public key parameters does not change the current key.\n";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 142);
            label7.Name = "label7";
            label7.Size = new Size(166, 40);
            label7.TabIndex = 20;
            label7.Text = "3) Click the Encrypt File button and select a file.\n";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 197);
            label8.Name = "label8";
            label8.Size = new Size(205, 60);
            label8.TabIndex = 21;
            label8.Text = "4) Click the Decrypt File button and select the file just encrypted.";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 272);
            label9.Name = "label9";
            label9.Size = new Size(163, 40);
            label9.TabIndex = 22;
            label9.Text = "5) Examine the file just decrypted.\n";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 325);
            label10.Name = "label10";
            label10.Size = new Size(208, 66);
            label10.TabIndex = 23;
            label10.Text = "6) Close the application and restart it to test retrieving persisted key containers in the next scenario.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(657, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 21;
            label4.Text = "Guide";
            // 
            // FileEncryptionTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FileEncryptionTab";
            Size = new Size(792, 417);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
