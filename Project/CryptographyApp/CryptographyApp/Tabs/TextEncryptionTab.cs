using System.Security.Cryptography;
using System.Text;
using CryptographyAppEngine;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Math;

namespace CryptographyApp.Tabs
{
    public partial class TextEncryptionTab : UserControl
    {
        private byte[] publicKey;
        private byte[] privateKey;
        private byte[] initializationVector;

        // Asymmetric Algorithms:
        private RSA rsa;
        // ElGamal (Using BouncyCastle):
        private ElGamalEngine elGamalEngine;
        private ElGamalKeyPairGenerator elGamalKeyPairGenerator;
        private AsymmetricCipherKeyPair elGamalKeyPair;
        // ECDSA (Using System.Security.Cryptography):
        private ECDsa ecdsa;

        // Symmetric Algorithms:
        private Aes aes;
        private DES des;
        private RC4 rc4;
        private IStreamCipher salsa20Cipher;
        private IStreamCipher chaCha20Cipher;

        private readonly Dictionary<string, string> algorithmImages = new()
        {
            { "RSA", "images/rsa.png" },
            { "AES", "images/aes.png" },
            { "DES", "images/des.png" },
            { "RC4", "images/rc4.png" },
            { "Salsa20", "images/salsa20.png" },
            { "ChaCha20", "images/chacha20.png" }
        };

        public TextEncryptionTab()
        {
            InitializeComponent();
            ConfigureUI();
            InitializeCryptoAlgorithms();
            PopulateAlgorithmTree();
            GenerateKeyAndIV();
        }

        private void ConfigureUI()
        {
            encryptOutputTextbox.ReadOnly = true;
            encryptInputTextbox.TextChanged += EncryptCurrentText;
            algorithmTreeView.BeforeSelect += AlgorithmTreeView_BeforeSelect;
            algorithmTreeView.AfterSelect += OnAlgorithmChanged;
            algorithmTreeView.HideSelection = false;
            algorithmTreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
            algorithmTreeView.DrawNode += AlgorithmTreeView_DrawNode;
            decryptionKeyTextbox.TextChanged += DecryptCurrentText;
        }

        private void DecryptCurrentText(object? sender, EventArgs e)
        {
            // Clear decryption output:
            decryptedTextbox.Text = string.Empty;

            // Get the current encryption algorithm:
            string selectedAlgorithm = algorithmTreeView.SelectedNode?.Text;
            if (selectedAlgorithm == null) return;

            // Get the encrypted text that will be decrypted:
            string encryptedText = encryptOutputTextbox.Text;
            if (string.IsNullOrEmpty(encryptedText)) { this.encryptOutputTextbox.Text = string.Empty; return; }
            byte[] data = Convert.FromBase64String(encryptedText);  // Expecting encrypted data in Base64 format.
            byte[] decryptedData = null;

            try
            {
                // Get the decryption key:
                byte[] decryptionKey = Convert.FromBase64String(decryptionKeyTextbox.Text.Trim());
                if (decryptionKey == null) return;

                switch (selectedAlgorithm)
                {
                    case "AES":
                        aes.Key = decryptionKey;
                        decryptedData = aes.DecryptCbc(data, this.initializationVector);
                        aes.Key = this.publicKey;
                        break;
                    case "DES":
                        des.Key = decryptionKey;
                        decryptedData = des.DecryptCbc(data, this.initializationVector);
                        des.Key = this.publicKey;
                        break;
                    case "RC4":
                        decryptedData = rc4.Decrypt(data, decryptionKey);
                        break;
                    case "Salsa20":
                        decryptedData = DecryptWithStreamCipher(salsa20Cipher, 8); // Salsa20 typically uses 8-byte nonce
                        break;

                    case "ChaCha20":
                        decryptedData = DecryptWithStreamCipher(chaCha20Cipher, 12); // ChaCha20 uses 12-byte nonce
                        break;
                    case "RSA":
                        rsa.ImportRSAPrivateKey(decryptionKey, out _);
                        decryptedData = rsa.Decrypt(data, RSAEncryptionPadding.OaepSHA256);
                        break;
                    case "ElGamal":
                        BigInteger privateKeyBigInt = new BigInteger(decryptionKey);  // Convert the private key to a BigInteger
                        // Extract the public key from the ElGamal key pair
                        ElGamalPublicKeyParameters elgamalpublickey = (ElGamalPublicKeyParameters)elGamalKeyPair.Public;

                        // Get the ElGamal parameters from the public key
                        ElGamalParameters elGamalParams = elgamalpublickey.Parameters;

                        // Now, construct the ElGamal private key parameters using the private key and the parameters from the public key
                        ElGamalPrivateKeyParameters privateKeyParams = new ElGamalPrivateKeyParameters(privateKeyBigInt, elGamalParams);
                        elGamalEngine.Init(false, privateKeyParams);
                        decryptedData = elGamalEngine.ProcessBlock(data, 0, data.Length);
                        break;

                    case "ECDSA":
                        // ECDSA is for signatures, not encryption, so no decryption here
                        // Assuming we don't decrypt with ECDSA and it’s used for signatures verification instead
                        break;
                }
            }
            catch (Exception ex)
            {
                decryptedTextbox.Text = "Decryption failed: " + ex.Message;
            }

            if (decryptedData != null)
            {
                string decryptedText = Encoding.UTF8.GetString(decryptedData);
                decryptedTextbox.Text = decryptedText;  // Display the decrypted text
            }
        }

        private byte[] DecryptWithStreamCipher(IStreamCipher cipher, int nonceSize)
        {
            // Use the nonce to initialize the cipher
            var nonce = GenerateRandomBytes(nonceSize);  // Assuming a fresh nonce is used for each decryption
            var keyParam = new KeyParameter(Encoding.UTF8.GetBytes(this.decryptionKeyTextbox.Text));
            cipher.Init(false, new ParametersWithIV(keyParam, nonce));  // Initialize for decryption (false for decryption mode)
            var output = new byte[nonce.Length];
            cipher.ProcessBytes(nonce, 0, nonce.Length, output, 0);
            return output;
        }

        private void InitializeCryptoAlgorithms()
        {
            rsa = RSA.Create();
            // ElGamal setup:
            elGamalEngine = new ElGamalEngine();
            // Initialize ElGamal Key Pair Generator
            elGamalKeyPairGenerator = new ElGamalKeyPairGenerator();
            // Generate ElGamal parameters and initialize the key pair generator
            ElGamalParametersGenerator elGamalParamsGen = new ElGamalParametersGenerator();
            elGamalParamsGen.Init(1024, 20, new SecureRandom()); // Set key size and certainty level
            ElGamalParameters elGamalParameters = elGamalParamsGen.GenerateParameters();
            // Initialize ElGamal key generation parameters with generated parameters
            ElGamalKeyGenerationParameters elGamalKeyGenParam = new ElGamalKeyGenerationParameters(new SecureRandom(), elGamalParameters);
            elGamalKeyPairGenerator.Init(elGamalKeyGenParam);
            // Generate the ElGamal key pair
            elGamalKeyPair = elGamalKeyPairGenerator.GenerateKeyPair();

            //ECDSA setup:
            ecdsa = new ECDsaCng();

            aes = Aes.Create();
            des = DES.Create();
            rc4 = new RC4();
            salsa20Cipher = new Salsa20Engine();
            chaCha20Cipher = new ChaCha7539Engine();
        }

        private void PopulateAlgorithmTree()
        {
            var asymmetricNode = new TreeNode("Asymmetric", new[] { new TreeNode("RSA"), new TreeNode("ElGamal"), new TreeNode("ECDSA") });
            var blockCiphersNode = new TreeNode("Block Ciphers", new[] { new TreeNode("AES"), new TreeNode("DES") });
            var streamCiphersNode = new TreeNode("Stream Ciphers", new[] { new TreeNode("RC4"), new TreeNode("Salsa20"), new TreeNode("ChaCha20") });
            var symmetricNode = new TreeNode("Symmetric", new[] { blockCiphersNode, streamCiphersNode });
            algorithmTreeView.Nodes.AddRange(new[] { asymmetricNode, symmetricNode });
            algorithmTreeView.ExpandAll();
        }

        private void AlgorithmTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            var isSelected = (e.State & TreeNodeStates.Selected) != 0;
            if (isSelected)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, algorithmTreeView.Font, e.Bounds, Color.Black, TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void AlgorithmTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
                e.Cancel = true;
        }

        private void OnAlgorithmChanged(object sender, EventArgs e)
        {
            GenerateKeyAndIV();
            UpdateUIWhenAlgorithmSelected();
            EncryptCurrentText(encryptInputTextbox, EventArgs.Empty); // Make sure to encrypt the data with the new algorithm as well
        }

        private void GenerateKeyAndIV()
        {
            string selectedAlgorithm = algorithmTreeView.SelectedNode?.Text;
            if (selectedAlgorithm == null) return;

            void GenerateSymmetricKey(SymmetricAlgorithm algorithm, int keySize)
            {
                algorithm.KeySize = keySize;
                algorithm.GenerateKey();
                algorithm.GenerateIV();
                publicKey = algorithm.Key;
                initializationVector = algorithm.IV;
            }

            switch (selectedAlgorithm)
            {
                case "AES":
                    GenerateSymmetricKey(aes, 256);
                    privateKey = null;
                    break;
                case "DES":
                    GenerateSymmetricKey(des, 64);
                    privateKey = null;
                    break;
                case "RC4":
                    publicKey = GenerateRandomBytes(16);
                    privateKey = null;
                    break;
                case "Salsa20":
                    publicKey = GenerateRandomBytes(32);
                    privateKey = null;
                    break;
                case "ChaCha20":
                    publicKey = GenerateRandomBytes(32);
                    privateKey = null;
                    break;
                case "RSA":
                    rsa.KeySize = 2048; // can be adjusted (2048 or 4096 is typical for RSA)
                    publicKey = rsa.ExportRSAPublicKey();
                    privateKey = rsa.ExportRSAPrivateKey();
                    break;
                case "ElGamal":
                    publicKey = ((ElGamalPublicKeyParameters)elGamalKeyPair.Public).Y.ToByteArray();
                    privateKey = ((ElGamalPrivateKeyParameters)elGamalKeyPair.Private).X.ToByteArray();
                    break;
                case "ECDSA":
                    publicKey = ecdsa.ExportSubjectPublicKeyInfo();
                    privateKey = ecdsa.ExportECPrivateKey();
                    break;
            }
        }

        private void UpdateUIWhenAlgorithmSelected()
        {
            currentEncryptAlgorithmTextbox.Text = algorithmTreeView.SelectedNode.Text;
            string selectedAlgorithm = algorithmTreeView.SelectedNode?.Text;
            switch (selectedAlgorithm)
            {
                case "AES":
                    AlgorithmFullnameTextbox.Text = "Advanced Encryption Standard";
                    AlgorithmDescriptionTextbox.Text = "AES is a widely used symmetric key encryption algorithm with key sizes of 128, 192, and 256 bits.";
                    break;
                case "DES":
                    AlgorithmFullnameTextbox.Text = "Data Encryption Standard";
                    AlgorithmDescriptionTextbox.Text = "DES is a symmetric-key algorithm that uses a 56-bit key, making it relatively weak today.";
                    break;
                case "RC4":
                    AlgorithmFullnameTextbox.Text = "RC4";
                    AlgorithmDescriptionTextbox.Text = "RC4 is a stream cipher with variable-length keys, now considered insecure.";
                    break;
                case "Salsa20":
                    AlgorithmFullnameTextbox.Text = "Salsa20";
                    AlgorithmDescriptionTextbox.Text = "Salsa20 is a fast stream cipher operating on 64-byte blocks.";
                    break;
                case "ChaCha20":
                    AlgorithmFullnameTextbox.Text = "ChaCha20";
                    AlgorithmDescriptionTextbox.Text = "ChaCha20 is a modern, secure stream cipher and a variant of Salsa20.";
                    break;
                case "RSA":
                    AlgorithmFullnameTextbox.Text = "RSA";
                    AlgorithmDescriptionTextbox.Text = "RSA is an asymmetric encryption algorithm used for secure data transmission.";
                    break;
                case "ElGamal":
                    AlgorithmFullnameTextbox.Text = "ElGamal";
                    AlgorithmDescriptionTextbox.Text = "ElGamal is an asymmetric encryption algorithm based on Diffie-Hellman key exchange, used for secure data transmission.";
                    break;
                case "ECDSA":
                    AlgorithmFullnameTextbox.Text = "Elliptic Curve Digital Signature Algorithm";
                    AlgorithmDescriptionTextbox.Text = "ECDSA is an asymmetric encryption algorithm used for digital signatures. It provides security through elliptic curve cryptography, offering smaller key sizes with equivalent security to RSA.";
                    break;

            }

            publicKeyTextbox.Text = publicKey != null ? Convert.ToBase64String(publicKey) : "N/A";
            privateKeyTextbox.Text = privateKey != null ? Convert.ToBase64String(privateKey) : "N/A";
            LoadAlgorithmImage(selectedAlgorithm);
        }

        private byte[] GenerateRandomBytes(int numBytes)
        {
            var bytes = new byte[numBytes];
            using var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return bytes;
        }

        private void LoadAlgorithmImage(string algorithm)
        {
            if (algorithmImages.TryGetValue(algorithm, out var imagePath))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                    pictureBox1.Image = null;
                }
            }
        }

        private void EncryptCurrentText(object sender, EventArgs e)
        {
            string selectedAlgorithm = algorithmTreeView.SelectedNode?.Text;
            int currentInputLength = this.encryptInputTextbox.Text.Length;
            int maxLength = GetMaxMessageLength(selectedAlgorithm);
            messageLengthLabel.Text = "Message Length: " + currentInputLength + "/" + maxLength;
            // Check if the input length exceeds the maximum allowed length
            if (currentInputLength > maxLength)
            {
                // Show warning in red and stop further processing
                messageLengthLabel.ForeColor = Color.Red;
                messageLengthLabel.Text += "\nMessage Length Exceeded! No longer encrypting.";
                encryptOutputTextbox.Text = string.Empty; // Clear the output textbox
                return; // Exit the method to prevent encryption
            }
            else
            {
                // Reset the label color back to default
                messageLengthLabel.ForeColor = Color.Black;
            }

            string plainText = encryptInputTextbox.Text;
            if (string.IsNullOrEmpty(plainText)) { this.encryptOutputTextbox.Text = string.Empty; return; }

            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedData = null;

            byte[] EncryptWithStreamCipher(IStreamCipher cipher, int nonceSize)
            {
                var nonce = GenerateRandomBytes(nonceSize);
                var keyParam = new KeyParameter(publicKey);
                cipher.Init(true, new ParametersWithIV(keyParam, nonce));
                var output = new byte[data.Length];
                cipher.ProcessBytes(data, 0, data.Length, output, 0);
                return output;
            }

            switch (selectedAlgorithm)
            {
                case "AES":
                    encryptedData = PerformCryptography(data, aes.CreateEncryptor(publicKey, initializationVector));
                    break;
                case "DES":
                    encryptedData = PerformCryptography(data, des.CreateEncryptor(publicKey, initializationVector));
                    break;
                case "RC4":
                    encryptedData = rc4.Encrypt(data, publicKey);
                    break;
                case "Salsa20":
                    encryptedData = EncryptWithStreamCipher(salsa20Cipher, 8);
                    break;
                case "ChaCha20":
                    encryptedData = EncryptWithStreamCipher(chaCha20Cipher, 12);
                    break;
                case "RSA":
                    encryptedData = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
                    break;
                case "ElGamal":
                    var plaintext = Encoding.UTF8.GetBytes(plainText);
                    elGamalEngine.Init(true, elGamalKeyPair.Public);  // Encryption mode
                    encryptedData = elGamalEngine.ProcessBlock(plaintext, 0, plaintext.Length);
                    break;
                case "ECDSA":
                    encryptedData = ecdsa.SignData(data, HashAlgorithmName.SHA256);
                    break;
                default:
                    encryptedData = null;
                    break;
            }

            if (encryptedData != null)
                encryptOutputTextbox.Text = Convert.ToBase64String(encryptedData);
        }

        private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptographer)
        {
            using var memoryStream = new System.IO.MemoryStream();
            using var cryptoStream = new CryptoStream(memoryStream, cryptographer, CryptoStreamMode.Write);
            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.FlushFinalBlock();
            return memoryStream.ToArray();
        }

        private int GetMaxMessageLength(string algorithm)
        {
            switch (algorithm)
            {
                case "AES":
                    return int.MaxValue; // No practical length limit for AES
                case "DES":
                    return int.MaxValue; // No practical length limit for DES
                case "RC4":
                    return int.MaxValue; // RC4 does not have a specific max length
                case "Salsa20":
                    return int.MaxValue; // Salsa20 does not have a specific max length
                case "ChaCha20":
                    return int.MaxValue; // ChaCha20 does not have a specific max length
                case "RSA":
                    return GetMaxRsaInputLength(rsa, RSAEncryptionPadding.Pkcs1); // e.g., 245 bytes for 2048-bit RSA
                case "ElGamal":
                    // The max message length for ElGamal will depend on key size. For 1024-bit keys, set an appropriate limit.
                    return 245 / 2; // Example for a 1024-bit key, adjust as needed
                case "ECDSA":
                    return int.MaxValue;
                default:
                    return -1; // Unknown or unsupported algorithm
            }
        }

        private int GetMaxRsaInputLength(RSA rsa, RSAEncryptionPadding padding)
        {
            // RSA key size in bytes minus padding overhead (11 bytes for PKCS1)
            return rsa.KeySize / 8 - (padding == RSAEncryptionPadding.Pkcs1 ? 11 : 0);
        }

        private void copyPublicButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(publicKeyTextbox.Text);
        }

        private void copyPrivateButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(privateKeyTextbox.Text);
        }

        private void pasteKeyButton_Click(object sender, EventArgs e)
        {
            decryptionKeyTextbox.Text = Clipboard.GetText();
        }
    }
}
