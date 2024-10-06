using System.Security.Cryptography;
using System.Text;
using CryptographyEngine.EncryptionAlgorithms.Symmetric.BlockCiphers;
using CryptographyEngine.HashingAlgorithms;

namespace CryptographyApp
{
    public partial class Form1 : Form
    {

        private byte[] _key;
        private byte[] _iv;

        public Form1()
        {
            InitializeComponent();

            // Disable editing on the output textboxes
            encryptOutputTextbox.ReadOnly = true;
            hashOutputTextbox.ReadOnly = true;

            // Populate hashing algorithms comboBox
            comboBoxHashing.Items.AddRange(new string[] { "SHA256", "SHA512", "MD5" });
            comboBoxHashing.SelectedIndex = 0;

            encryptInputTextbox.TextChanged += EncryptCurrentText;
            hashInputTextbox.TextChanged += HashCurrentText;
            algorithmTreeView.BeforeSelect += algorithmTreeView_BeforeSelect;
            algorithmTreeView.AfterSelect += OnAlgorithmChanged;
            comboBoxHashing.SelectedIndexChanged += OnAlgorithmChanged;

            // Settings for the tree:
            algorithmTreeView.HideSelection = false;
            algorithmTreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
            algorithmTreeView.DrawNode += algorithmTreeView_DrawNode;
            PopulateAlgorithmTree();

            // Generate a new key and IV for AES/DES when the form is initialized
            GenerateKeyAndIV();
        }

        // Add this code in your form's constructor or initialization method
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
                // Draw the background for the selected node
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds); // Change the color to your preference

                // Draw the node text with a custom color (optional)
                TextRenderer.DrawText(e.Graphics, e.Node.Text, algorithmTreeView.Font, e.Bounds, Color.Black, TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                // Draw the node text normally if it's not selected
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
            else if (sender is ComboBox hashComboBox && hashComboBox.Name == "comboBoxHashing")
            {
                HashCurrentText(hashInputTextbox, new EventArgs());
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
            // Handle RSA differently if needed
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
                encryptedData = AESEncryption.Encrypt(data, _key, _iv);
            }
            else if (selectedAlgorithm == "DES")
            {
                encryptedData = DESEncryption.Encrypt(data, _key, _iv); // Implement this in your DESEncryption class
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


        private void buttonCreateAsmKeys_Click(object sender, EventArgs e)
        {
            // Stores a key pair in the key container.
            _cspp.KeyContainerName = KeyName;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };

            label1.Text = _rsa.PublicOnly
                ? $"Key: {_cspp.KeyContainerName} - Public Only"
                : $"Key: {_cspp.KeyContainerName} - Full Key Pair";
        }

        private void buttonEncryptFile_Click(object sender, EventArgs e)
        {
            if (_rsa is null)
            {
                MessageBox.Show("Key not set.");
            }
            else
            {
                // Display a dialog box to select a file to encrypt.
                _encryptOpenFileDialog.InitialDirectory = SrcFolder;
                if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = _encryptOpenFileDialog.FileName;
                    if (fName != null)
                    {
                        // Pass the file name without the path.
                        EncryptFile(new FileInfo(fName));
                    }
                }
            }
        }

        private void EncryptFile(FileInfo file)
        {
            // Create instance of Aes for
            // symmetric encryption of the data.
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            // Use RSACryptoServiceProvider to
            // encrypt the AES key.
            // rsa is previously instantiated:
            //    rsa = new RSACryptoServiceProvider(cspp);
            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false);

            // Create byte arrays to contain
            // the length values of the key and IV.
            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            // Write the following to the FileStream
            // for the encrypted file (outFs):
            // - length of the key
            // - length of the IV
            // - encrypted key
            // - the IV
            // - the encrypted cipher content

            // Change the file's extension to ".enc"
            string outFile =
                Path.Combine(EncrFolder, Path.ChangeExtension(file.Name, ".enc"));

            using (var outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(aes.IV, 0, lIV);

                // Now write the cipher text using
                // a CryptoStream for encrypting.
                using (var outStreamEncrypted =
                    new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                    // By encrypting a chunk at
                    // a time, you can save memory
                    // and accommodate large files.
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (var inFs = new FileStream(file.FullName, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        } while (count > 0);
                    }
                    outStreamEncrypted.FlushFinalBlock();
                }
            }
        }

        private void buttonDecryptFile_Click(object sender, EventArgs e)
        {
            if (_rsa is null)
            {
                MessageBox.Show("Key not set.");
            }
            else
            {
                // Display a dialog box to select the encrypted file.
                _decryptOpenFileDialog.InitialDirectory = EncrFolder;
                if (_decryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = _decryptOpenFileDialog.FileName;
                    if (fName != null)
                    {
                        DecryptFile(new FileInfo(fName));
                    }
                }
            }
        }

        private void DecryptFile(FileInfo file)
        {
            // Create instance of Aes for
            // symmetric decryption of the data.
            Aes aes = Aes.Create();

            // Create byte arrays to get the length of
            // the encrypted key and IV.
            // These values were stored as 4 bytes each
            // at the beginning of the encrypted package.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Construct the file name for the decrypted file.
            string outFile =
                Path.ChangeExtension(file.FullName.Replace("Encrypt", "Decrypt"), ".txt");

            // Use FileStream objects to read the encrypted
            // file (inFs) and save the decrypted file (outFs).
            using (var inFs = new FileStream(file.FullName, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                // Convert the lengths to integer values.
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                // Determine the start position of
                // the cipher text (startC)
                // and its length(lenC).
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                // Create the byte arrays for
                // the encrypted Aes key,
                // the IV, and the cipher text.
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                // Extract the key and IV
                // starting from index 8
                // after the length values.
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);

                Directory.CreateDirectory(DecrFolder);
                // Use RSACryptoServiceProvider
                // to decrypt the AES key.
                byte[] KeyDecrypted = _rsa.Decrypt(KeyEncrypted, false);

                // Decrypt the key.
                ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                // Decrypt the cipher text from
                // from the FileSteam of the encrypted
                // file (inFs) into the FileStream
                // for the decrypted file (outFs).
                using (var outFs = new FileStream(outFile, FileMode.Create))
                {
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                    // By decrypting a chunk a time,
                    // you can save memory and
                    // accommodate large files.

                    // Start at the beginning
                    // of the cipher text.
                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (var outStreamDecrypted =
                        new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        } while (count > 0);

                        outStreamDecrypted.FlushFinalBlock();
                    }
                }
            }
        }

        void buttonExportPublicKey_Click(object sender, EventArgs e)
        {
            // Save the public key created by the RSA
            // to a file. Caution, persisting the
            // key to a file is a security risk.
            Directory.CreateDirectory(EncrFolder);
            using (var sw = new StreamWriter(PubKeyFile, false))
            {
                sw.Write(_rsa.ToXmlString(false));
            }
        }

        void buttonImportPublicKey_Click(object sender, EventArgs e)
        {
            using (var sr = new StreamReader(PubKeyFile))
            {
                _cspp.KeyContainerName = KeyName;
                _rsa = new RSACryptoServiceProvider(_cspp);

                string keytxt = sr.ReadToEnd();
                _rsa.FromXmlString(keytxt);
                _rsa.PersistKeyInCsp = true;

                label1.Text = _rsa.PublicOnly
                    ? $"Key: {_cspp.KeyContainerName} - Public Only"
                    : $"Key: {_cspp.KeyContainerName} - Full Key Pair";
            }
        }

        private void buttonGetPrivateKey_Click(object sender, EventArgs e)
        {
            _cspp.KeyContainerName = KeyName;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };

            label1.Text = _rsa.PublicOnly
                ? $"Key: {_cspp.KeyContainerName} - Public Only"
                : $"Key: {_cspp.KeyContainerName} - Full Key Pair";
        }
    }
}
