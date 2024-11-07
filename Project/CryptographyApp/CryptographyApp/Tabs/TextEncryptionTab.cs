using System.Security.Cryptography;
using System.Text;
using CryptographyAppEngine;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Engines;

namespace CryptographyApp.Tabs
{
    public partial class TextEncryptionTab : UserControl
    {
        private byte[] publicKey;
        private byte[] privateKey;
        private byte[] initializationVector;

        // Asymmetric Algorithms:
        private RSA rsa;

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
        }

        private void InitializeCryptoAlgorithms()
        {
            rsa = RSA.Create();
            aes = Aes.Create();
            des = DES.Create();
            rc4 = new RC4();
            salsa20Cipher = new Salsa20Engine();
            chaCha20Cipher = new ChaCha7539Engine();
        }

        private void PopulateAlgorithmTree()
        {
            var asymmetricNode = new TreeNode("Asymmetric", new[] { new TreeNode("RSA") });
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
            UpdateUIForAlgorithm();
            EncryptCurrentText(encryptInputTextbox, EventArgs.Empty);
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
                    rsa.KeySize = 2048; // Adjust as needed (2048 or 4096 is typical for RSA)
                    publicKey = rsa.ExportRSAPublicKey();
                    privateKey = rsa.ExportRSAPrivateKey();
                    break;
            }
        }

        private void UpdateUIForAlgorithm()
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
            }

            publicKeyTextbox.Text = publicKey != null ? Convert.ToBase64String(publicKey) : "N/A";
            privateKeyTextbox.Text = privateKey != null ? Encoding.UTF8.GetString(privateKey) : "N/A";
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
            string plainText = encryptInputTextbox.Text;
            if (string.IsNullOrEmpty(plainText)) return;

            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedData = null;
            string selectedAlgorithm = algorithmTreeView.SelectedNode?.Text;

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
                    return;
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
    }
}
