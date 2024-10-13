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
            currentEncryptAlgorithmTextbox = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(396, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 12;
            label1.Text = "Enter Text:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(86, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 13;
            label2.Text = "Select an Algorithm:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(618, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 14;
            label3.Text = "Encrypted Text:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(118, 205);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 16;
            label5.Text = "Public Key:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(392, 205);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 17;
            label6.Text = "Private Key:";
            // 
            // encryptInputTextbox
            // 
            encryptInputTextbox.Dock = DockStyle.Fill;
            encryptInputTextbox.Location = new Point(319, 23);
            encryptInputTextbox.Name = "encryptInputTextbox";
            encryptInputTextbox.Size = new Size(231, 179);
            encryptInputTextbox.TabIndex = 18;
            encryptInputTextbox.Text = "";
            encryptInputTextbox.TextChanged += EncryptCurrentText;
            // 
            // encryptOutputTextbox
            // 
            encryptOutputTextbox.Dock = DockStyle.Fill;
            encryptOutputTextbox.Location = new Point(556, 23);
            encryptOutputTextbox.Name = "encryptOutputTextbox";
            encryptOutputTextbox.Size = new Size(233, 179);
            encryptOutputTextbox.TabIndex = 19;
            encryptOutputTextbox.Text = "";
            // 
            // algorithmTreeView
            // 
            algorithmTreeView.Dock = DockStyle.Fill;
            algorithmTreeView.Location = new Point(3, 23);
            algorithmTreeView.Name = "algorithmTreeView";
            algorithmTreeView.Size = new Size(310, 179);
            algorithmTreeView.TabIndex = 20;
            // 
            // publicKeyTextbox
            // 
            publicKeyTextbox.Anchor = AnchorStyles.Top;
            publicKeyTextbox.Location = new Point(95, 228);
            publicKeyTextbox.Name = "publicKeyTextbox";
            publicKeyTextbox.Size = new Size(125, 27);
            publicKeyTextbox.TabIndex = 22;
            // 
            // privateKeyTextbox
            // 
            privateKeyTextbox.Anchor = AnchorStyles.Top;
            privateKeyTextbox.Location = new Point(372, 228);
            privateKeyTextbox.Name = "privateKeyTextbox";
            privateKeyTextbox.Size = new Size(125, 27);
            privateKeyTextbox.TabIndex = 23;
            // 
            // currentEncryptAlgorithmTextbox
            // 
            currentEncryptAlgorithmTextbox.Location = new Point(3, 281);
            currentEncryptAlgorithmTextbox.Name = "currentEncryptAlgorithmTextbox";
            currentEncryptAlgorithmTextbox.Size = new Size(125, 27);
            currentEncryptAlgorithmTextbox.TabIndex = 21;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(556, 281);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(233, 316);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 258);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 25;
            label8.Text = "Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 258);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 24;
            label7.Text = "Full Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 258);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 15;
            label4.Text = "Current Algorithm:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(encryptOutputTextbox, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 5);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label7, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(publicKeyTextbox, 0, 3);
            tableLayoutPanel1.Controls.Add(privateKeyTextbox, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 2, 4);
            tableLayoutPanel1.Controls.Add(richTextBox1, 2, 5);
            tableLayoutPanel1.Controls.Add(currentEncryptAlgorithmTextbox, 0, 5);
            tableLayoutPanel1.Controls.Add(label6, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(algorithmTreeView, 0, 1);
            tableLayoutPanel1.Controls.Add(encryptInputTextbox, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(792, 600);
            tableLayoutPanel1.TabIndex = 13;
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
        private TextBox currentEncryptAlgorithmTextbox;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
