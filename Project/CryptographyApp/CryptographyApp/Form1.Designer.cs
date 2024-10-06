using System.Security.Cryptography;

namespace CryptographyApp
{
    partial class Form1
    {
        // Declare CspParameters and RsaCryptoServiceProvider
        // objects with global scope of your Form class.
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;

        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        const string EncrFolder = @"c:\Encrypt\";
        const string DecrFolder = @"c:\Decrypt\";
        const string SrcFolder = @"c:\docs\";

        // Public key file
        const string PubKeyFile = @"c:\encrypt\rsaPublicKey.txt";

        // Key container name for
        // private/public key value pair.
        const string KeyName = "Key01";

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonEncryptFile = new Button();
            buttonDecryptFile = new Button();
            buttonCreateAsmKeys = new Button();
            buttonExportPublicKey = new Button();
            buttonImportPublicKey = new Button();
            buttonGetPrivateKey = new Button();
            label1 = new Label();
            _encryptOpenFileDialog = new OpenFileDialog();
            _decryptOpenFileDialog = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            privateKeyTextbox = new TextBox();
            publicKeyTextbox = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label4 = new Label();
            currentEncryptAlgorithmTextbox = new TextBox();
            label10 = new Label();
            algorithmTreeView = new TreeView();
            encryptOutputTextbox = new RichTextBox();
            encryptInputTextbox = new RichTextBox();
            label8 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            label7 = new Label();
            hashInputTextbox = new RichTextBox();
            hashOutputTextbox = new RichTextBox();
            label6 = new Label();
            comboBoxHashing = new ComboBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEncryptFile
            // 
            buttonEncryptFile.Location = new Point(57, 122);
            buttonEncryptFile.Name = "buttonEncryptFile";
            buttonEncryptFile.Size = new Size(154, 29);
            buttonEncryptFile.TabIndex = 0;
            buttonEncryptFile.Text = "Encrypt File\t";
            buttonEncryptFile.UseVisualStyleBackColor = true;
            buttonEncryptFile.Click += buttonEncryptFile_Click;
            // 
            // buttonDecryptFile
            // 
            buttonDecryptFile.Location = new Point(57, 170);
            buttonDecryptFile.Name = "buttonDecryptFile";
            buttonDecryptFile.Size = new Size(154, 29);
            buttonDecryptFile.TabIndex = 1;
            buttonDecryptFile.Text = "Decrypt File";
            buttonDecryptFile.UseVisualStyleBackColor = true;
            buttonDecryptFile.Click += buttonDecryptFile_Click;
            // 
            // buttonCreateAsmKeys
            // 
            buttonCreateAsmKeys.Location = new Point(57, 24);
            buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            buttonCreateAsmKeys.Size = new Size(154, 29);
            buttonCreateAsmKeys.TabIndex = 2;
            buttonCreateAsmKeys.Text = "Create Asm Keys";
            buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            buttonCreateAsmKeys.Click += buttonCreateAsmKeys_Click;
            // 
            // buttonExportPublicKey
            // 
            buttonExportPublicKey.Location = new Point(57, 76);
            buttonExportPublicKey.Name = "buttonExportPublicKey";
            buttonExportPublicKey.Size = new Size(154, 29);
            buttonExportPublicKey.TabIndex = 3;
            buttonExportPublicKey.Text = "Export Public Key";
            buttonExportPublicKey.UseVisualStyleBackColor = true;
            buttonExportPublicKey.Click += buttonExportPublicKey_Click;
            // 
            // buttonImportPublicKey
            // 
            buttonImportPublicKey.Location = new Point(310, 170);
            buttonImportPublicKey.Name = "buttonImportPublicKey";
            buttonImportPublicKey.Size = new Size(142, 29);
            buttonImportPublicKey.TabIndex = 4;
            buttonImportPublicKey.Text = "Import Public Key";
            buttonImportPublicKey.UseVisualStyleBackColor = true;
            buttonImportPublicKey.Click += buttonImportPublicKey_Click;
            // 
            // buttonGetPrivateKey
            // 
            buttonGetPrivateKey.Location = new Point(314, 240);
            buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            buttonGetPrivateKey.Size = new Size(133, 29);
            buttonGetPrivateKey.TabIndex = 5;
            buttonGetPrivateKey.Text = "Get Private Key";
            buttonGetPrivateKey.UseVisualStyleBackColor = true;
            buttonGetPrivateKey.Click += buttonGetPrivateKey_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Key not set";
            // 
            // _encryptOpenFileDialog
            // 
            _encryptOpenFileDialog.FileName = "openFileDialog1";
            // 
            // _decryptOpenFileDialog
            // 
            _decryptOpenFileDialog.FileName = "openFileDialog2";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(privateKeyTextbox);
            tabPage1.Controls.Add(publicKeyTextbox);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(currentEncryptAlgorithmTextbox);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(algorithmTreeView);
            tabPage1.Controls.Add(encryptOutputTextbox);
            tabPage1.Controls.Add(encryptInputTextbox);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Text Encryption";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // privateKeyTextbox
            // 
            privateKeyTextbox.Location = new Point(414, 322);
            privateKeyTextbox.Name = "privateKeyTextbox";
            privateKeyTextbox.ReadOnly = true;
            privateKeyTextbox.Size = new Size(125, 27);
            privateKeyTextbox.TabIndex = 17;
            // 
            // publicKeyTextbox
            // 
            publicKeyTextbox.Location = new Point(261, 322);
            publicKeyTextbox.Name = "publicKeyTextbox";
            publicKeyTextbox.ReadOnly = true;
            publicKeyTextbox.Size = new Size(125, 27);
            publicKeyTextbox.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(414, 299);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 15;
            label11.Text = "Private Key:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(261, 299);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 14;
            label9.Text = "Public Key:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 237);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 13;
            label4.Text = "Current Algorithm:";
            // 
            // currentEncryptAlgorithmTextbox
            // 
            currentEncryptAlgorithmTextbox.Location = new Point(324, 260);
            currentEncryptAlgorithmTextbox.Name = "currentEncryptAlgorithmTextbox";
            currentEncryptAlgorithmTextbox.ReadOnly = true;
            currentEncryptAlgorithmTextbox.Size = new Size(143, 27);
            currentEncryptAlgorithmTextbox.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(324, 42);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 11;
            label10.Text = "Select an Algorithm:";
            // 
            // algorithmTreeView
            // 
            algorithmTreeView.Location = new Point(288, 65);
            algorithmTreeView.Name = "algorithmTreeView";
            algorithmTreeView.Size = new Size(211, 169);
            algorithmTreeView.TabIndex = 10;
            // 
            // encryptOutputTextbox
            // 
            encryptOutputTextbox.Location = new Point(535, 65);
            encryptOutputTextbox.Name = "encryptOutputTextbox";
            encryptOutputTextbox.ReadOnly = true;
            encryptOutputTextbox.Size = new Size(214, 222);
            encryptOutputTextbox.TabIndex = 7;
            encryptOutputTextbox.Text = "";
            // 
            // encryptInputTextbox
            // 
            encryptInputTextbox.Location = new Point(31, 65);
            encryptInputTextbox.Name = "encryptInputTextbox";
            encryptInputTextbox.Size = new Size(214, 222);
            encryptInputTextbox.TabIndex = 6;
            encryptInputTextbox.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(564, 42);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 5;
            label8.Text = "Encrypted Text:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 42);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Text:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(hashInputTextbox);
            tabPage3.Controls.Add(hashOutputTextbox);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(comboBoxHashing);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Text Hashing";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(576, 47);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 6;
            label7.Text = "Hashed Text:";
            // 
            // hashInputTextbox
            // 
            hashInputTextbox.Location = new Point(29, 70);
            hashInputTextbox.Name = "hashInputTextbox";
            hashInputTextbox.Size = new Size(214, 222);
            hashInputTextbox.TabIndex = 5;
            hashInputTextbox.Text = "";
            // 
            // hashOutputTextbox
            // 
            hashOutputTextbox.Location = new Point(513, 70);
            hashOutputTextbox.Name = "hashOutputTextbox";
            hashOutputTextbox.ReadOnly = true;
            hashOutputTextbox.Size = new Size(214, 222);
            hashOutputTextbox.TabIndex = 4;
            hashOutputTextbox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 126);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 3;
            label6.Text = "Select an Algorithm";
            // 
            // comboBoxHashing
            // 
            comboBoxHashing.FormattingEnabled = true;
            comboBoxHashing.Location = new Point(286, 149);
            comboBoxHashing.Name = "comboBoxHashing";
            comboBoxHashing.Size = new Size(162, 28);
            comboBoxHashing.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 47);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "Enter Text:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(buttonExportPublicKey);
            tabPage2.Controls.Add(buttonImportPublicKey);
            tabPage2.Controls.Add(buttonCreateAsmKeys);
            tabPage2.Controls.Add(buttonGetPrivateKey);
            tabPage2.Controls.Add(buttonDecryptFile);
            tabPage2.Controls.Add(buttonEncryptFile);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "File Encrpytion";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(446, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(338, 297);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 28);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 7;
            label3.Text = "Current Key:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEncryptFile;
        private Button buttonDecryptFile;
        private Button buttonCreateAsmKeys;
        private Button buttonExportPublicKey;
        private Button buttonImportPublicKey;
        private Button buttonGetPrivateKey;
        private Label label1;
        private OpenFileDialog _encryptOpenFileDialog;
        private OpenFileDialog _decryptOpenFileDialog;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private TabPage tabPage3;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxHashing;
        private Label label7;
        private RichTextBox hashInputTextbox;
        private RichTextBox hashOutputTextbox;
        private RichTextBox encryptOutputTextbox;
        private RichTextBox encryptInputTextbox;
        private Label label8;
        private Label label10;
        private TreeView algorithmTreeView;
        private Label label4;
        private TextBox currentEncryptAlgorithmTextbox;
        private TextBox privateKeyTextbox;
        private TextBox publicKeyTextbox;
        private Label label11;
        private Label label9;
    }
}
