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
            label1 = new Label();
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
            tableLayoutPanel2 = new TableLayoutPanel();
            currentEncryptAlgorithmTextbox = new TextBox();
            AlgorithmFullnameTextbox = new TextBox();
            AlgorithmDescriptionTextbox = new RichTextBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(356, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 12;
            label1.Text = "Enter Text:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(60, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 13;
            label2.Text = "Select an Algorithm:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(604, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 14;
            label3.Text = "Encrypted Text:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(91, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 16;
            label5.Text = "Public Key:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(89, 53);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 17;
            label6.Text = "Private Key:";
            // 
            // encryptInputTextbox
            // 
            encryptInputTextbox.Dock = DockStyle.Fill;
            encryptInputTextbox.Location = new Point(266, 23);
            encryptInputTextbox.Name = "encryptInputTextbox";
            encryptInputTextbox.Size = new Size(257, 179);
            encryptInputTextbox.TabIndex = 18;
            encryptInputTextbox.Text = "";
            encryptInputTextbox.TextChanged += EncryptCurrentText;
            // 
            // encryptOutputTextbox
            // 
            encryptOutputTextbox.Dock = DockStyle.Fill;
            encryptOutputTextbox.Location = new Point(529, 23);
            encryptOutputTextbox.Name = "encryptOutputTextbox";
            encryptOutputTextbox.Size = new Size(260, 179);
            encryptOutputTextbox.TabIndex = 19;
            encryptOutputTextbox.Text = "";
            // 
            // algorithmTreeView
            // 
            algorithmTreeView.Dock = DockStyle.Fill;
            algorithmTreeView.Location = new Point(3, 23);
            algorithmTreeView.Name = "algorithmTreeView";
            algorithmTreeView.Size = new Size(257, 179);
            algorithmTreeView.TabIndex = 20;
            // 
            // publicKeyTextbox
            // 
            publicKeyTextbox.Dock = DockStyle.Fill;
            publicKeyTextbox.Location = new Point(3, 23);
            publicKeyTextbox.Name = "publicKeyTextbox";
            publicKeyTextbox.Size = new Size(257, 27);
            publicKeyTextbox.TabIndex = 22;
            // 
            // privateKeyTextbox
            // 
            privateKeyTextbox.Dock = DockStyle.Fill;
            privateKeyTextbox.Location = new Point(3, 76);
            privateKeyTextbox.Name = "privateKeyTextbox";
            privateKeyTextbox.Size = new Size(257, 27);
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
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(encryptOutputTextbox, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(algorithmTreeView, 0, 1);
            tableLayoutPanel1.Controls.Add(encryptInputTextbox, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 7);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
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
            tableLayoutPanel2.Size = new Size(257, 389);
            tableLayoutPanel2.TabIndex = 29;
            // 
            // currentEncryptAlgorithmTextbox
            // 
            currentEncryptAlgorithmTextbox.Dock = DockStyle.Fill;
            currentEncryptAlgorithmTextbox.Location = new Point(3, 23);
            currentEncryptAlgorithmTextbox.Name = "currentEncryptAlgorithmTextbox";
            currentEncryptAlgorithmTextbox.Size = new Size(251, 27);
            currentEncryptAlgorithmTextbox.TabIndex = 21;
            // 
            // AlgorithmFullnameTextbox
            // 
            AlgorithmFullnameTextbox.Dock = DockStyle.Fill;
            AlgorithmFullnameTextbox.Location = new Point(3, 76);
            AlgorithmFullnameTextbox.Name = "AlgorithmFullnameTextbox";
            AlgorithmFullnameTextbox.Size = new Size(251, 27);
            AlgorithmFullnameTextbox.TabIndex = 26;
            // 
            // AlgorithmDescriptionTextbox
            // 
            AlgorithmDescriptionTextbox.Dock = DockStyle.Fill;
            AlgorithmDescriptionTextbox.Location = new Point(3, 129);
            AlgorithmDescriptionTextbox.Name = "AlgorithmDescriptionTextbox";
            AlgorithmDescriptionTextbox.ReadOnly = true;
            AlgorithmDescriptionTextbox.Size = new Size(251, 257);
            AlgorithmDescriptionTextbox.TabIndex = 27;
            AlgorithmDescriptionTextbox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(266, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(privateKeyTextbox, 0, 3);
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Controls.Add(publicKeyTextbox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(529, 208);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(260, 389);
            tableLayoutPanel3.TabIndex = 30;
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
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
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
    }
}
