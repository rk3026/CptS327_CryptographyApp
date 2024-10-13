using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CryptographyApp.Tabs
{
    public partial class TextEncryptionTab : UserControl
    {
        private byte[] _key;
        private byte[] _iv;

        public TextEncryptionTab()
        {
            InitializeComponent();

            // Disable editing on the output textboxes
            encryptOutputTextbox.ReadOnly = true;

            encryptInputTextbox.TextChanged += EncryptCurrentText;
            algorithmTreeView.BeforeSelect += algorithmTreeView_BeforeSelect;
            algorithmTreeView.AfterSelect += OnAlgorithmChanged;

            // Settings for the tree:
            algorithmTreeView.HideSelection = false;
            algorithmTreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
            algorithmTreeView.DrawNode += algorithmTreeView_DrawNode;
            PopulateAlgorithmTree();

            // Generate a new key and IV for AES/DES when the form is initialized
            GenerateKeyAndIV();
        }

        public void PopulateAlgorithmTree()
        {
            // Create the root nodes (categories)
            TreeNode asymmetricNode = new TreeNode("Asymmetric");
            TreeNode symmetricNode = new TreeNode("Symmetric");

            // Add child nodes under Asymmetric (e.g., RSA)
            TreeNode rsaNode = new TreeNode("RSA");
            asymmetricNode.Nodes.Add(rsaNode);

            // Add child nodes under Symmetric
            TreeNode streamCiphersNode = new TreeNode("Stream Ciphers");
            TreeNode blockCiphersNode = new TreeNode("Block Ciphers");

            // Add child nodes under Block Ciphers (e.g., AES, DES)
            TreeNode aesNode = new TreeNode("AES");
            TreeNode desNode = new TreeNode("DES");
            blockCiphersNode.Nodes.Add(aesNode);
            blockCiphersNode.Nodes.Add(desNode);

            symmetricNode.Nodes.Add(streamCiphersNode);
            symmetricNode.Nodes.Add(blockCiphersNode);

            // Add root nodes to the TreeView
            algorithmTreeView.Nodes.Add(asymmetricNode);
            algorithmTreeView.Nodes.Add(symmetricNode);

            // Expand the root nodes (optional)
            algorithmTreeView.ExpandAll();
        }

        private void algorithmTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // Check if the node is selected
            bool isSelected = (e.State & TreeNodeStates.Selected) != 0;

            // Custom background color for selected nodes
            if (isSelected)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds); // Change the color to your preference
                TextRenderer.DrawText(e.Graphics, e.Node.Text, algorithmTreeView.Font, e.Bounds, Color.Black, TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void algorithmTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            // Check if the node has child nodes (i.e., it's not a leaf node)
            if (e.Node.Nodes.Count > 0)
            {
                // Cancel the selection if the node is not a leaf node
                e.Cancel = true;
            }
        }

        // This method will handle the algorithm change
        private void OnAlgorithmChanged(object sender, EventArgs e)
        {
            if (sender is TreeView tv && tv.Name == "algorithmTreeView")
            {
                currentEncryptAlgorithmTextbox.Text = algorithmTreeView.SelectedNode.Text;
                GenerateKeyAndIV(); // Regenerate key and IV based on the selected algorithm
                EncryptCurrentText(encryptInputTextbox, new EventArgs());
            }
        }

        private void GenerateKeyAndIV()
        {
            // Choose the algorithm type
            string selectedAlgorithm = algorithmTreeView.SelectedNode?.Text;  // Get the selected node's text

            if (selectedAlgorithm == "AES")
            {
                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = 256; // Set key size to 256 bits
                    aes.GenerateKey();
                    aes.GenerateIV();
                    _key = aes.Key;
                    _iv = aes.IV;
                }
            }
            else if (selectedAlgorithm == "DES")
            {
                using (DES des = DES.Create())
                {
                    des.GenerateKey(); // Generates a valid 64-bit key (8 bytes)
                    des.GenerateIV();  // Generates an initialization vector
                    _key = des.Key;
                    _iv = des.IV;
                }
            }

            if (_key != null)
            {
                publicKeyTextbox.Text = Convert.ToBase64String(_key); // Display the key in Base64 format
            }
        }

        private void EncryptCurrentText(object sender, EventArgs e)
        {
            string plainText = encryptInputTextbox.Text;
            if (string.IsNullOrEmpty(plainText)) { return; }

            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedData = null;

            // Check selected encryption algorithm
            string selectedAlgorithm = algorithmTreeView.SelectedNode?.Text; // Get the selected algorithm text
            if (selectedAlgorithm == "AES")
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = _key;
                    aes.IV = _iv;

                    using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    {
                        encryptedData = PerformCryptography(data, encryptor);
                    }
                }
            }
            else if (selectedAlgorithm == "DES")
            {
                using (DES des = DES.Create())
                {
                    des.Key = _key;
                    des.IV = _iv;

                    using (var encryptor = des.CreateEncryptor(des.Key, des.IV))
                    {
                        encryptedData = PerformCryptography(data, encryptor);
                    }
                }
            }
            else if (selectedAlgorithm == "RSA")
            {
                // Handle RSA encryption here if implemented
                return;
            }
            else
            {
                Console.WriteLine("No valid algorithm selected.");
                return;
            }

            // Display the encrypted text in Base64 format
            encryptOutputTextbox.Text = Convert.ToBase64String(encryptedData);
        }

        private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                using (var cs = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    cs.FlushFinalBlock();
                }
                return ms.ToArray();
            }
        }
    }
}
