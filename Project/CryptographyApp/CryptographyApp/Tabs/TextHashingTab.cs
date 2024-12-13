using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CryptographyApp
{
    public partial class TextHashingTab : UserControl
    {
        // Private algorithm instances for reuse
        private SHA256 _sha256;
        private SHA512 _sha512;
        private MD5 _md5;
        private ECDsa ecdsa; // ECDSA (Using System.Security.Cryptography):

        public TextHashingTab()
        {
            InitializeComponent();

            // Initialize the hashing algorithms
            _sha256 = SHA256.Create();
            _sha512 = SHA512.Create();
            _md5 = MD5.Create();
            ecdsa = new ECDsaCng(); //ECDSA setup:

            // Populate hashing algorithms comboBox
            comboBoxHashing.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHashing.Items.AddRange(new string[] { "SHA256", "SHA512", "MD5", "ECDSA" });
            //comboBoxHashing.SelectedIndex = 0;

            // Attach event handlers for real-time hashing and updates to algorithm details
            hashInputTextbox.TextChanged += HashCurrentText;
            comboBoxHashing.SelectedIndexChanged += OnAlgorithmChanged;
        }

        private void OnAlgorithmChanged(object sender, EventArgs e)
        {
            // Update hash and show algorithm information
            UpdateAlgorithmInfo();
            HashCurrentText(sender, e);
        }

        private void UpdateAlgorithmInfo()
        {
            // Get the selected algorithm
            string selectedAlgorithm = comboBoxHashing.SelectedItem as string;

            // Set values based on the selected algorithm
            switch (selectedAlgorithm)
            {
                case "SHA256":
                    currentHashAlgorithmTextbox.Text = "SHA256";
                    fullHashAlgorithmNameTextbox.Text = "Secure Hash Algorithm 256-bit";
                    algorithmDescriptionTextbox.Text = "SHA256 generates a 256-bit hash, widely used for data integrity.";
                    break;
                case "SHA512":
                    currentHashAlgorithmTextbox.Text = "SHA512";
                    fullHashAlgorithmNameTextbox.Text = "Secure Hash Algorithm 512-bit";
                    algorithmDescriptionTextbox.Text = "SHA512 generates a 512-bit hash, ideal for enhanced security in data hashing.";
                    break;
                case "MD5":
                    currentHashAlgorithmTextbox.Text = "MD5";
                    fullHashAlgorithmNameTextbox.Text = "Message Digest Algorithm 5";
                    algorithmDescriptionTextbox.Text = "MD5 is a 128-bit hash function, faster but less secure than SHA algorithms.";
                    break;
                case "ECDSA":
                    currentHashAlgorithmTextbox.Text = "ECDSA";
                    fullHashAlgorithmNameTextbox.Text = "Elliptic Curve Digital Signature Algorithm";
                    algorithmDescriptionTextbox.Text = "ECDSA is an asymmetric encryption algorithm used for digital signatures. It provides security through elliptic curve cryptography, offering smaller key sizes with equivalent security to RSA.";
                    break;
                default:
                    currentHashAlgorithmTextbox.Text = "";
                    fullHashAlgorithmNameTextbox.Text = "";
                    algorithmDescriptionTextbox.Text = "Select a hashing algorithm to view details.";
                    break;
            }
        }

        private void HashCurrentText(object sender, EventArgs e)
        {
            string inputText = hashInputTextbox.Text;
            if (string.IsNullOrEmpty(inputText))
            {
                hashOutputTextbox.Text = string.Empty; // Clear output if input is empty
                return;
            }

            string selectedAlgorithm = comboBoxHashing.SelectedItem as string;
            byte[] hashBytes = null;

            // Select the pre-created hashing algorithm based on user selection
            switch (selectedAlgorithm)
            {
                case "SHA256":
                    hashBytes = _sha256.ComputeHash(Encoding.UTF8.GetBytes(inputText));
                    break;
                case "SHA512":
                    hashBytes = _sha512.ComputeHash(Encoding.UTF8.GetBytes(inputText));
                    break;
                case "MD5":
                    hashBytes = _md5.ComputeHash(Encoding.UTF8.GetBytes(inputText));
                    break;
                case "ECDSA":
                    hashBytes = ecdsa.SignData(Encoding.UTF8.GetBytes(inputText), HashAlgorithmName.SHA256);
                    break;
            }

            // Convert the byte array to a hexadecimal string
            hashOutputTextbox.Text = hashBytes != null
                ? BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
                : string.Empty;
        }
    }
}
