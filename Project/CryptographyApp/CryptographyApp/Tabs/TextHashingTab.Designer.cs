namespace CryptographyApp
{
    partial class TextHashingTab
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
            label7 = new Label();
            hashInputTextbox = new RichTextBox();
            hashOutputTextbox = new RichTextBox();
            label6 = new Label();
            comboBoxHashing = new ComboBox();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            currentHashAlgorithmTextbox = new TextBox();
            label2 = new Label();
            fullHashAlgorithmNameTextbox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            algorithmDescriptionTextbox = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(613, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 12;
            label7.Text = "Hashed Text:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // hashInputTextbox
            // 
            hashInputTextbox.Dock = DockStyle.Fill;
            hashInputTextbox.Location = new Point(266, 23);
            hashInputTextbox.Name = "hashInputTextbox";
            hashInputTextbox.Size = new Size(258, 98);
            hashInputTextbox.TabIndex = 11;
            hashInputTextbox.Text = "";
            // 
            // hashOutputTextbox
            // 
            hashOutputTextbox.Dock = DockStyle.Fill;
            hashOutputTextbox.EnableAutoDragDrop = true;
            hashOutputTextbox.Location = new Point(530, 23);
            hashOutputTextbox.Name = "hashOutputTextbox";
            hashOutputTextbox.ReadOnly = true;
            hashOutputTextbox.Size = new Size(259, 98);
            hashOutputTextbox.TabIndex = 10;
            hashOutputTextbox.Text = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(61, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 9;
            label6.Text = "Select an Algorithm";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxHashing
            // 
            comboBoxHashing.Dock = DockStyle.Fill;
            comboBoxHashing.FormattingEnabled = true;
            comboBoxHashing.Location = new Point(3, 23);
            comboBoxHashing.Name = "comboBoxHashing";
            comboBoxHashing.Size = new Size(257, 28);
            comboBoxHashing.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(356, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 7;
            label5.Text = "Enter Text:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(hashOutputTextbox, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxHashing, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(hashInputTextbox, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(792, 417);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(currentHashAlgorithmTextbox, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(fullHashAlgorithmNameTextbox, 0, 4);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 5);
            tableLayoutPanel2.Controls.Add(algorithmDescriptionTextbox, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 127);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(257, 287);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // currentHashAlgorithmTextbox
            // 
            currentHashAlgorithmTextbox.Anchor = AnchorStyles.None;
            currentHashAlgorithmTextbox.Location = new Point(3, 23);
            currentHashAlgorithmTextbox.Name = "currentHashAlgorithmTextbox";
            currentHashAlgorithmTextbox.Size = new Size(251, 27);
            currentHashAlgorithmTextbox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 14;
            label2.Text = "Full Name:";
            // 
            // fullHashAlgorithmNameTextbox
            // 
            fullHashAlgorithmNameTextbox.Location = new Point(3, 76);
            fullHashAlgorithmNameTextbox.Name = "fullHashAlgorithmNameTextbox";
            fullHashAlgorithmNameTextbox.Size = new Size(251, 27);
            fullHashAlgorithmNameTextbox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 13;
            label1.Text = "Current Algorithm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 106);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 15;
            label3.Text = "Description:";
            // 
            // algorithmDescriptionTextbox
            // 
            algorithmDescriptionTextbox.Dock = DockStyle.Fill;
            algorithmDescriptionTextbox.Location = new Point(3, 129);
            algorithmDescriptionTextbox.Name = "algorithmDescriptionTextbox";
            algorithmDescriptionTextbox.Size = new Size(251, 155);
            algorithmDescriptionTextbox.TabIndex = 18;
            algorithmDescriptionTextbox.Text = "";
            // 
            // TextHashingTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TextHashingTab";
            Size = new Size(792, 417);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private RichTextBox hashInputTextbox;
        private RichTextBox hashOutputTextbox;
        private Label label6;
        private ComboBox comboBoxHashing;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox currentHashAlgorithmTextbox;
        private TextBox fullHashAlgorithmNameTextbox;
        private RichTextBox algorithmDescriptionTextbox;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
