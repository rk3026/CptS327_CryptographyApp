using CryptographyEngine.HashingAlgorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyApp
{
    public partial class TextHashingTab : UserControl
    {
        public TextHashingTab()
        {
            InitializeComponent();

            // Populate hashing algorithms comboBox
            comboBoxHashing.Items.AddRange(new string[] { "SHA256", "SHA512", "MD5" });
            comboBoxHashing.SelectedIndex = 0;

            hashInputTextbox.TextChanged += HashCurrentText;
            comboBoxHashing.SelectedIndexChanged += OnAlgorithmChanged;
        }

        // This method will handle the algorithm change
        private void OnAlgorithmChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox hashComboBox && hashComboBox.Name == "comboBoxHashing")
            {
                HashCurrentText(hashInputTextbox, new EventArgs());
            }
        }


        private void HashCurrentText(object sender, EventArgs e)
        {
            string inputText = hashInputTextbox.Text;
            if (string.IsNullOrEmpty(inputText)) { return; }

            string selectedAlgorithm = comboBoxHashing.SelectedItem as string;

            string hashedText = string.Empty;

            if (selectedAlgorithm == "SHA256")
            {
                byte[] hashBytes = SHA256Hashing.ComputeHash(inputText);
                hashedText = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
            else if (selectedAlgorithm == "SHA512")
            {
                byte[] hashBytes = SHA512Hashing.ComputeHash(inputText);
                hashedText = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
            else if (selectedAlgorithm == "MD5")
            {
                byte[] hashBytes = MD5Hashing.ComputeHash(inputText);
                hashedText = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            // Update a UI component (e.g., a label or textbox) to show the hashed text
            hashOutputTextbox.Text = hashedText; // Ensure you have a textbox for output
        }

    }
}
