namespace CryptographyApp.Tabs
{
    partial class TextEncryptionTab
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
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            encryptInputTextbox = new RichTextBox();
            encryptOutputTextbox = new RichTextBox();
            algorithmTreeView = new TreeView();
            publicKeyTextbox = new TextBox();
            privateKeyTextbox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label11 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            currentEncryptAlgorithmTextbox = new TextBox();
            AlgorithmFullnameTextbox = new TextBox();
            AlgorithmDescriptionTextbox = new RichTextBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            copyPublicButton = new Button();
            copyPrivateButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            messageLengthLabel = new Label();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            decryptedTextbox = new RichTextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            decryptionKeyTextbox = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            pasteKeyButton = new Button();
            clearButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(7, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 13;
            label2.Text = "Select an Algorithm:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(340, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 14;
            label3.Text = "Encrypted Text:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(11, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 40);
            label5.TabIndex = 16;
            label5.Text = "Public Key:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(9, 75);
            label6.Name = "label6";
            label6.Size = new Size(58, 40);
            label6.TabIndex = 17;
            label6.Text = "Private Key:";
            // 
            // encryptInputTextbox
            // 
            encryptInputTextbox.Dock = DockStyle.Fill;
            encryptInputTextbox.Location = new Point(3, 3);
            encryptInputTextbox.Name = "encryptInputTextbox";
            encryptInputTextbox.Size = new Size(146, 153);
            encryptInputTextbox.TabIndex = 18;
            encryptInputTextbox.Text = "";
            // 
            // encryptOutputTextbox
            // 
            encryptOutputTextbox.Dock = DockStyle.Fill;
            encryptOutputTextbox.Location = new Point(319, 23);
            encryptOutputTextbox.Name = "encryptOutputTextbox";
            encryptOutputTextbox.ReadOnly = true;
            encryptOutputTextbox.Size = new Size(152, 179);
            encryptOutputTextbox.TabIndex = 19;
            encryptOutputTextbox.Text = "";
            // 
            // algorithmTreeView
            // 
            algorithmTreeView.Dock = DockStyle.Fill;
            algorithmTreeView.Location = new Point(3, 23);
            algorithmTreeView.Name = "algorithmTreeView";
            algorithmTreeView.Size = new Size(152, 179);
            algorithmTreeView.TabIndex = 20;
            // 
            // publicKeyTextbox
            // 
            publicKeyTextbox.Dock = DockStyle.Fill;
            publicKeyTextbox.Location = new Point(3, 43);
            publicKeyTextbox.Name = "publicKeyTextbox";
            publicKeyTextbox.ReadOnly = true;
            publicKeyTextbox.Size = new Size(70, 27);
            publicKeyTextbox.TabIndex = 22;
            // 
            // privateKeyTextbox
            // 
            privateKeyTextbox.Dock = DockStyle.Fill;
            privateKeyTextbox.Location = new Point(3, 118);
            privateKeyTextbox.Name = "privateKeyTextbox";
            privateKeyTextbox.ReadOnly = true;
            privateKeyTextbox.Size = new Size(70, 27);
            privateKeyTextbox.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 106);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 25;
            label8.Text = "Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 53);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 24;
            label7.Text = "Full Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 15;
            label4.Text = "Current Algorithm:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(encryptOutputTextbox, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label11, 3, 7);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(algorithmTreeView, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 3, 0);
            tableLayoutPanel1.Controls.Add(label10, 4, 0);
            tableLayoutPanel1.Controls.Add(decryptedTextbox, 4, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(792, 600);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(494, 342);
            label11.Name = "label11";
            label11.Size = new Size(118, 120);
            label11.TabIndex = 36;
            label11.Text = "Algorithm is Symmetric: Use Public Key\r\nAlgorithm is Asymmetric: Use Private Key\r\n";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(currentEncryptAlgorithmTextbox, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(AlgorithmFullnameTextbox, 0, 3);
            tableLayoutPanel2.Controls.Add(AlgorithmDescriptionTextbox, 0, 5);
            tableLayoutPanel2.Controls.Add(label8, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 208);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(152, 389);
            tableLayoutPanel2.TabIndex = 29;
            // 
            // currentEncryptAlgorithmTextbox
            // 
            currentEncryptAlgorithmTextbox.Dock = DockStyle.Fill;
            currentEncryptAlgorithmTextbox.Location = new Point(3, 23);
            currentEncryptAlgorithmTextbox.Name = "currentEncryptAlgorithmTextbox";
            currentEncryptAlgorithmTextbox.Size = new Size(146, 27);
            currentEncryptAlgorithmTextbox.TabIndex = 21;
            // 
            // AlgorithmFullnameTextbox
            // 
            AlgorithmFullnameTextbox.Dock = DockStyle.Fill;
            AlgorithmFullnameTextbox.Location = new Point(3, 76);
            AlgorithmFullnameTextbox.Name = "AlgorithmFullnameTextbox";
            AlgorithmFullnameTextbox.Size = new Size(146, 27);
            AlgorithmFullnameTextbox.TabIndex = 26;
            // 
            // AlgorithmDescriptionTextbox
            // 
            AlgorithmDescriptionTextbox.Dock = DockStyle.Fill;
            AlgorithmDescriptionTextbox.Location = new Point(3, 129);
            AlgorithmDescriptionTextbox.Name = "AlgorithmDescriptionTextbox";
            AlgorithmDescriptionTextbox.ReadOnly = true;
            AlgorithmDescriptionTextbox.Size = new Size(146, 257);
            AlgorithmDescriptionTextbox.TabIndex = 27;
            AlgorithmDescriptionTextbox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(161, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(privateKeyTextbox, 0, 3);
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Controls.Add(publicKeyTextbox, 0, 1);
            tableLayoutPanel3.Controls.Add(copyPublicButton, 1, 1);
            tableLayoutPanel3.Controls.Add(copyPrivateButton, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(319, 208);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(152, 389);
            tableLayoutPanel3.TabIndex = 30;
            // 
            // copyPublicButton
            // 
            copyPublicButton.Location = new Point(79, 43);
            copyPublicButton.Name = "copyPublicButton";
            copyPublicButton.Size = new Size(70, 29);
            copyPublicButton.TabIndex = 24;
            copyPublicButton.Text = "Copy";
            copyPublicButton.UseVisualStyleBackColor = true;
            copyPublicButton.Click += copyPublicButton_Click;
            // 
            // copyPrivateButton
            // 
            copyPrivateButton.Location = new Point(79, 118);
            copyPrivateButton.Name = "copyPrivateButton";
            copyPrivateButton.Size = new Size(70, 29);
            copyPrivateButton.TabIndex = 25;
            copyPrivateButton.Text = "Copy";
            copyPrivateButton.UseVisualStyleBackColor = true;
            copyPrivateButton.Click += copyPrivateButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(encryptInputTextbox, 0, 0);
            tableLayoutPanel4.Controls.Add(messageLengthLabel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(161, 23);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(152, 179);
            tableLayoutPanel4.TabIndex = 31;
            // 
            // messageLengthLabel
            // 
            messageLengthLabel.Anchor = AnchorStyles.None;
            messageLengthLabel.AutoSize = true;
            messageLengthLabel.Location = new Point(16, 159);
            messageLengthLabel.Name = "messageLengthLabel";
            messageLengthLabel.Size = new Size(119, 20);
            messageLengthLabel.TabIndex = 19;
            messageLengthLabel.Text = "Message Length:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(198, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 32;
            label1.Text = "Enter Text:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(477, 0);
            label9.Name = "label9";
            label9.Size = new Size(151, 20);
            label9.TabIndex = 34;
            label9.Text = "Enter Decryption Key:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(656, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 35;
            label10.Text = "Decrypted Text:";
            // 
            // decryptedTextbox
            // 
            decryptedTextbox.Dock = DockStyle.Fill;
            decryptedTextbox.Location = new Point(635, 23);
            decryptedTextbox.Name = "decryptedTextbox";
            decryptedTextbox.ReadOnly = true;
            decryptedTextbox.Size = new Size(154, 179);
            decryptedTextbox.TabIndex = 37;
            decryptedTextbox.Text = "";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(decryptionKeyTextbox, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(477, 23);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(152, 179);
            tableLayoutPanel5.TabIndex = 38;
            // 
            // decryptionKeyTextbox
            // 
            decryptionKeyTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            decryptionKeyTextbox.Location = new Point(25, 59);
            decryptionKeyTextbox.Margin = new Padding(25, 3, 25, 3);
            decryptionKeyTextbox.Name = "decryptionKeyTextbox";
            decryptionKeyTextbox.Size = new Size(102, 27);
            decryptionKeyTextbox.TabIndex = 33;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(pasteKeyButton, 1, 0);
            tableLayoutPanel6.Controls.Add(clearButton, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 92);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(146, 84);
            tableLayoutPanel6.TabIndex = 34;
            // 
            // pasteKeyButton
            // 
            pasteKeyButton.Location = new Point(76, 3);
            pasteKeyButton.Name = "pasteKeyButton";
            pasteKeyButton.Size = new Size(59, 29);
            pasteKeyButton.TabIndex = 34;
            pasteKeyButton.Text = "Paste";
            pasteKeyButton.UseVisualStyleBackColor = true;
            pasteKeyButton.Click += pasteKeyButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.Location = new Point(3, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(67, 29);
            clearButton.TabIndex = 35;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // TextEncryptionTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TextEncryptionTab";
            Size = new Size(792, 600);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private RichTextBox encryptInputTextbox;
        private RichTextBox encryptOutputTextbox;
        private TreeView algorithmTreeView;
        private TextBox publicKeyTextbox;
        private TextBox privateKeyTextbox;
        private Label label8;
        private Label label7;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TextBox currentEncryptAlgorithmTextbox;
        private RichTextBox AlgorithmDescriptionTextbox;
        private TextBox AlgorithmFullnameTextbox;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label messageLengthLabel;
        private Label label1;
        private TextBox decryptionKeyTextbox;
        private Label label9;
        private Label label10;
        private Label label11;
        private RichTextBox decryptedTextbox;
        private Button copyPublicButton;
        private Button copyPrivateButton;
        private TableLayoutPanel tableLayoutPanel5;
        private Button pasteKeyButton;
        private TableLayoutPanel tableLayoutPanel6;
        private Button clearButton;
    }
}
