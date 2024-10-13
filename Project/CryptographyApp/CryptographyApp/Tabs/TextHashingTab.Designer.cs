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
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 80);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 12;
            label7.Text = "Hashed Text:";
            // 
            // hashInputTextbox
            // 
            hashInputTextbox.Location = new Point(40, 103);
            hashInputTextbox.Name = "hashInputTextbox";
            hashInputTextbox.Size = new Size(214, 222);
            hashInputTextbox.TabIndex = 11;
            hashInputTextbox.Text = "";
            // 
            // hashOutputTextbox
            // 
            hashOutputTextbox.Location = new Point(524, 103);
            hashOutputTextbox.Name = "hashOutputTextbox";
            hashOutputTextbox.ReadOnly = true;
            hashOutputTextbox.Size = new Size(214, 222);
            hashOutputTextbox.TabIndex = 10;
            hashOutputTextbox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 159);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 9;
            label6.Text = "Select an Algorithm";
            // 
            // comboBoxHashing
            // 
            comboBoxHashing.FormattingEnabled = true;
            comboBoxHashing.Location = new Point(297, 182);
            comboBoxHashing.Name = "comboBoxHashing";
            comboBoxHashing.Size = new Size(162, 28);
            comboBoxHashing.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 80);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 7;
            label5.Text = "Enter Text:";
            // 
            // TextHashingTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(hashInputTextbox);
            Controls.Add(hashOutputTextbox);
            Controls.Add(label6);
            Controls.Add(comboBoxHashing);
            Controls.Add(label5);
            Name = "TextHashingTab";
            Size = new Size(792, 417);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private RichTextBox hashInputTextbox;
        private RichTextBox hashOutputTextbox;
        private Label label6;
        private ComboBox comboBoxHashing;
        private Label label5;
    }
}
