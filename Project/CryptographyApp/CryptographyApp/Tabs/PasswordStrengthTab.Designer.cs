namespace CryptographyApp.Tabs
{
    partial class PasswordStrengthTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordStrengthTab));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            strengthLabel = new Label();
            entropyLabel = new Label();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            passwordTextbox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            weakPasswordButton = new Button();
            strongPasswordButton = new Button();
            moderatePasswordButton = new Button();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.99999F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(792, 417);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(strengthLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(entropyLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(richTextBox1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(398, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(391, 411);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // strengthLabel
            // 
            strengthLabel.Anchor = AnchorStyles.None;
            strengthLabel.AutoSize = true;
            strengthLabel.Location = new Point(31, 58);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(68, 20);
            strengthLabel.TabIndex = 2;
            strengthLabel.Text = "Strength:";
            // 
            // entropyLabel
            // 
            entropyLabel.Anchor = AnchorStyles.None;
            entropyLabel.AutoSize = true;
            entropyLabel.Location = new Point(33, 194);
            entropyLabel.Name = "entropyLabel";
            entropyLabel.Size = new Size(63, 20);
            entropyLabel.TabIndex = 3;
            entropyLabel.Text = "Entropy:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(19, 332);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 4;
            label4.Text = "Suggestions:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(passwordTextbox, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(389, 411);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(132, 116);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter a password:";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Anchor = AnchorStyles.Top;
            passwordTextbox.Location = new Point(69, 139);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(251, 27);
            passwordTextbox.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(weakPasswordButton, 0, 0);
            tableLayoutPanel4.Controls.Add(strongPasswordButton, 2, 0);
            tableLayoutPanel4.Controls.Add(moderatePasswordButton, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 275);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(383, 133);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // weakPasswordButton
            // 
            weakPasswordButton.Dock = DockStyle.Fill;
            weakPasswordButton.Location = new Point(3, 3);
            weakPasswordButton.Name = "weakPasswordButton";
            weakPasswordButton.RightToLeft = RightToLeft.No;
            weakPasswordButton.Size = new Size(121, 127);
            weakPasswordButton.TabIndex = 5;
            weakPasswordButton.Text = "Generate Weak Password";
            weakPasswordButton.UseVisualStyleBackColor = true;
            weakPasswordButton.Click += weakPasswordButton_Click;
            // 
            // strongPasswordButton
            // 
            strongPasswordButton.Dock = DockStyle.Fill;
            strongPasswordButton.Location = new Point(257, 3);
            strongPasswordButton.Name = "strongPasswordButton";
            strongPasswordButton.Size = new Size(123, 127);
            strongPasswordButton.TabIndex = 7;
            strongPasswordButton.Text = "Generate Strong Password";
            strongPasswordButton.UseVisualStyleBackColor = true;
            strongPasswordButton.Click += strongPasswordButton_Click;
            // 
            // moderatePasswordButton
            // 
            moderatePasswordButton.Dock = DockStyle.Fill;
            moderatePasswordButton.Location = new Point(130, 3);
            moderatePasswordButton.Name = "moderatePasswordButton";
            moderatePasswordButton.Size = new Size(121, 127);
            moderatePasswordButton.TabIndex = 6;
            moderatePasswordButton.Text = "Generate Moderate Password";
            moderatePasswordButton.UseVisualStyleBackColor = true;
            moderatePasswordButton.Click += moderatePasswordButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(133, 139);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(124, 131);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // PasswordStrengthTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PasswordStrengthTab";
            Size = new Size(792, 417);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox passwordTextbox;
        private Label label1;
        private Label strengthLabel;
        private Label entropyLabel;
        private Label label4;
        private Button weakPasswordButton;
        private Button moderatePasswordButton;
        private Button strongPasswordButton;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private RichTextBox richTextBox1;
    }
}
