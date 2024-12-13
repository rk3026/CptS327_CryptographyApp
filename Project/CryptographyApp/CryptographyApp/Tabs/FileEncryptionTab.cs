using System.Security.Cryptography;

namespace CryptographyApp
{
    public partial class FileEncryptionTab : UserControl
    {
        private enum EncryptionMode
        {
            EncryptPublicDecryptPrivate,
            EncryptPrivateDecryptPublic
        }

        private EncryptionMode _currentMode = EncryptionMode.EncryptPublicDecryptPrivate;

        private readonly CspParameters _cspp = new CspParameters();
        private RSACryptoServiceProvider _rsa;

        private string _appDirectory = Application.StartupPath; // Current app directory
        private string _userAppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CryptographyApp");

        private string EncrFolder;
        private string DecrFolder;
        private string SrcFolder;
        private string KeyFolder;

        public FileEncryptionTab()
        {
            InitializeComponent();
            EnsureDirectoriesExist();
            _rsa = new RSACryptoServiceProvider(_cspp) { PersistKeyInCsp = true };
            authenticityRadioButton.Click += SwitchMode;
            confidentialityRadioButton.Click += SwitchMode;
            UpdateKeyStatus();
        }

        private void SwitchMode(object? sender, EventArgs e)
        {
            if (authenticityRadioButton.Checked)
            {
                // Set mode to Authenticity (Encrypt with Public, Decrypt with Private)
                _currentMode = EncryptionMode.EncryptPublicDecryptPrivate;
            }
            else if (confidentialityRadioButton.Checked)
            {
                // Set mode to Confidentiality (Encrypt with Private, Decrypt with Public)
                _currentMode = EncryptionMode.EncryptPrivateDecryptPublic;
            }
        }


        private void EnsureDirectoriesExist()
        {
            try
            {
                // Default folders within the app directory or AppData
                EncrFolder = Path.Combine(_userAppDataFolder, "EncryptedFiles");
                DecrFolder = Path.Combine(_userAppDataFolder, "DecryptedFiles");
                SrcFolder = Path.Combine(_userAppDataFolder, "SourceFiles");
                KeyFolder = Path.Combine(_userAppDataFolder, "Keys");

                Directory.CreateDirectory(EncrFolder);
                Directory.CreateDirectory(DecrFolder);
                Directory.CreateDirectory(SrcFolder);
                Directory.CreateDirectory(KeyFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating directories: {ex.Message}");
            }
        }

        private void buttonCreateAsmKeys_Click(object sender, EventArgs e)
        {
            try
            {
                _rsa = new RSACryptoServiceProvider(_cspp)
                {
                    PersistKeyInCsp = true,
                };
                UpdateKeyStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating key pair: {ex.Message}");
            }
        }

        private void UpdateKeyStatus()
        {
            if (_rsa != null)
            {
                // Export the public key as a byte array and convert it to a Base64 string for display
                byte[] publicKeyBytes = _rsa.ExportRSAPublicKey();
                publicKeyLabel.Text = Convert.ToBase64String(publicKeyBytes); // Display the public key as a Base64 string

                // Export the private key as a byte array and convert it to a Base64 string for display
                byte[] privateKeyBytes = _rsa.ExportPkcs8PrivateKey();
                privateKeyLabel.Text = Convert.ToBase64String(privateKeyBytes); // Display the private key as a Base64 string
            }
        }


        private void buttonImportPublicKey_Click(object sender, EventArgs e)
        {
            _keyOpenFileDialog.InitialDirectory = KeyFolder;
            _keyOpenFileDialog.Title = "Select Public Key File";
            _keyOpenFileDialog.FileName = string.Empty;

            if (_keyOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string keyFile = _keyOpenFileDialog.FileName;
                    // Ensure the key file exists and read its contents
                    if (!File.Exists(keyFile))
                    {
                        throw new FileNotFoundException("Public key file not found.");
                    }

                    // Read the public key from the file
                    string publicKeyXml = File.ReadAllText(keyFile);

                    // Import the public key into the RSA object
                    using (RSA rsa = RSA.Create())
                    {
                        rsa.FromXmlString(publicKeyXml); // Assuming the key is in XML format
                    }
                    UpdateKeyStatus();
                    MessageBox.Show("Public key imported successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Key import failed: {ex.Message}");
                }
            }
        }

        private void buttonEncryptFile_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Key pair is not set. Generate or import keys first.");
                return;
            }

            _encryptOpenFileDialog.InitialDirectory = SrcFolder;
            _encryptOpenFileDialog.Title = "Select File to Encrypt";
            _encryptOpenFileDialog.FileName = string.Empty;

            if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string inputFile = _encryptOpenFileDialog.FileName;

                    using (var saveDialog = new SaveFileDialog
                    {
                        InitialDirectory = EncrFolder,
                        Title = "Save Encrypted File",
                        FileName = Path.GetFileName(inputFile) + ".enc",
                        Filter = "Encrypted Files (*.enc)|*.enc|All Files (*.*)|*.*",
                    })
                    {
                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            EncryptFile(new FileInfo(inputFile), saveDialog.FileName);
                            MessageBox.Show("File successfully encrypted!");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Encryption failed: {ex.Message}");
                }
            }
        }

        private void EncryptFile(FileInfo file, string outFile)
        {
            if (!file.Exists)
                throw new FileNotFoundException("The file to encrypt does not exist.");

            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC; // Specify CBC mode for AES
                byte[] keyEncrypted;

                if (_currentMode == EncryptionMode.EncryptPublicDecryptPrivate)
                {
                    // Encrypt AES key with Public Key
                    keyEncrypted = _rsa.Encrypt(aes.Key, false);
                }
                else
                {
                    // Encrypt AES key with Private Key
                    keyEncrypted = _rsa.Decrypt(aes.Key, false);
                }

                byte[] LenK = BitConverter.GetBytes(keyEncrypted.Length);
                byte[] LenIV = BitConverter.GetBytes(aes.IV.Length);

                using (var outFs = new FileStream(outFile, FileMode.Create))
                {
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(LenIV, 0, 4);
                    outFs.Write(keyEncrypted, 0, keyEncrypted.Length);
                    outFs.Write(aes.IV, 0, aes.IV.Length);

                    using (var encryptStream = new CryptoStream(outFs, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (var inFs = new FileStream(file.FullName, FileMode.Open))
                        {
                            byte[] buffer = new byte[4096];
                            int read;
                            while ((read = inFs.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                encryptStream.Write(buffer, 0, read);
                            }
                        }
                        encryptStream.FlushFinalBlock();
                    }
                }
            }
        }


        private void buttonDecryptFile_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Key pair is not set. Generate or import keys first.");
                return;
            }

            _decryptOpenFileDialog.InitialDirectory = EncrFolder;
            _decryptOpenFileDialog.Title = "Select Encrypted File to Decrypt";
            _decryptOpenFileDialog.FileName = string.Empty;

            if (_decryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string encryptedFile = _decryptOpenFileDialog.FileName;

                    // Remove the .enc extension from the original file name
                    string decryptedFileName = Path.GetFileNameWithoutExtension(encryptedFile);

                    // Let the user choose where to save the decrypted file
                    using (var saveDialog = new SaveFileDialog
                    {
                        InitialDirectory = DecrFolder,
                        FileName = decryptedFileName, // Set the file name without the .enc extension
                        Title = "Save Decrypted File",
                        Filter = "All files (*.*)|*.*", // Allows saving as any file type
                        DefaultExt = Path.GetExtension(decryptedFileName) // Set default extension based on the original file type
                    })
                    {
                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            DecryptFile(new FileInfo(encryptedFile), saveDialog.FileName);
                            MessageBox.Show("File successfully decrypted!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Decryption failed: {ex.Message}");
                }
            }
        }


        // To decrypt with a given key
        private void buttonDecryptFileOther_Click(object sender, EventArgs e)
        {
            _decryptOpenFileDialog.InitialDirectory = EncrFolder;
            _decryptOpenFileDialog.Title = "Select Encrypted File to Decrypt";
            _decryptOpenFileDialog.FileName = string.Empty;

            if (_decryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string encryptedFile = _decryptOpenFileDialog.FileName;
                    // Remove the .enc extension from the original file name
                    string decryptedFileName = Path.GetFileNameWithoutExtension(encryptedFile);

                    // Prompt user to select the private key file for decryption
                    _keyOpenFileDialog.InitialDirectory = KeyFolder;
                    _keyOpenFileDialog.Title = "Select Private Key for Decryption";
                    _keyOpenFileDialog.FileName = string.Empty;

                    if (_keyOpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Read and import the selected private key for decryption
                        string privateKeyFile = _keyOpenFileDialog.FileName;
                        string privateKeyXml = File.ReadAllText(privateKeyFile);
                        RSA rsaForDecryption = RSA.Create();
                        rsaForDecryption.FromXmlString(privateKeyXml);

                        // Let the user choose where to save the decrypted file
                        using (var saveDialog = new SaveFileDialog
                        {
                            InitialDirectory = DecrFolder,
                            FileName = decryptedFileName, // Set the file name without the .enc extension
                            Title = "Save Decrypted File",
                            Filter = "All files (*.*)|*.*", // Allows saving as any file type
                            DefaultExt = Path.GetExtension(decryptedFileName) // Set default extension based on the original file type
                        })
                        {
                            if (saveDialog.ShowDialog() == DialogResult.OK)
                            {
                                DecryptFile(new FileInfo(encryptedFile), saveDialog.FileName, rsaForDecryption);
                                MessageBox.Show("File successfully decrypted!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Decryption failed: {ex.Message}");
                }
            }
        }

        private void DecryptFile(FileInfo file, string outFile)
        {
            if (!file.Exists)
                throw new FileNotFoundException("The file to decrypt does not exist.");

            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC; // Ensure same mode as encryption
                using (var inFs = new FileStream(file.FullName, FileMode.Open))
                {
                    byte[] LenK = new byte[4];
                    byte[] LenIV = new byte[4];
                    inFs.Read(LenK, 0, 4);
                    inFs.Read(LenIV, 0, 4);

                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Read(IV, 0, lenIV);

                    byte[] KeyDecrypted;

                    if (_currentMode == EncryptionMode.EncryptPublicDecryptPrivate)
                    {
                        KeyDecrypted = _rsa.Decrypt(KeyEncrypted, false);
                    }
                    else
                    {
                        KeyDecrypted = _rsa.Encrypt(KeyEncrypted, false);
                    }

                    // Save the decrypted file with the original extension
                    string decryptedFileName = Path.Combine(DecrFolder, Path.GetFileNameWithoutExtension(file.FullName));

                    using (var outFs = new FileStream(decryptedFileName, FileMode.Create))
                    using (var decryptStream = new CryptoStream(outFs, aes.CreateDecryptor(KeyDecrypted, IV), CryptoStreamMode.Write))
                    {
                        byte[] buffer = new byte[4096];
                        int read;
                        while ((read = inFs.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            decryptStream.Write(buffer, 0, read);
                        }
                        decryptStream.FlushFinalBlock();
                    }
                }
            }
        }



        private void DecryptFile(FileInfo file, string outFile, RSA rsaForDecryption)
        {
            if (!file.Exists)
                throw new FileNotFoundException("The file to decrypt does not exist.");

            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC; // Ensure same mode as encryption
                using (var inFs = new FileStream(file.FullName, FileMode.Open))
                {
                    byte[] LenK = new byte[4];
                    byte[] LenIV = new byte[4];
                    inFs.Read(LenK, 0, 4);
                    inFs.Read(LenIV, 0, 4);

                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Read(IV, 0, lenIV);

                    byte[] KeyDecrypted;

                    // Use the selected private key for decryption
                    KeyDecrypted = rsaForDecryption.Decrypt(KeyEncrypted, RSAEncryptionPadding.Pkcs1);

                    using (var outFs = new FileStream(outFile, FileMode.Create))
                    using (var decryptStream = new CryptoStream(outFs, aes.CreateDecryptor(KeyDecrypted, IV), CryptoStreamMode.Write))
                    {
                        byte[] buffer = new byte[4096];
                        int read;
                        while ((read = inFs.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            decryptStream.Write(buffer, 0, read);
                        }
                        decryptStream.FlushFinalBlock();
                    }
                }
            }
        }


        private void buttonExportPublicKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rsa == null)
                {
                    MessageBox.Show("Generate or import keys before exporting.");
                    return;
                }

                // Open the SaveFileDialog to allow the user to select a location and file name
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.Title = "Save Public Key";
                    saveFileDialog.InitialDirectory = KeyFolder;

                    // Set default file name
                    saveFileDialog.FileName = "MyPublicKey";

                    // Show the dialog and check if the user selected a file path
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Write the public key to the selected file
                        File.WriteAllText(saveFileDialog.FileName, _rsa.ToXmlString(false));
                        MessageBox.Show("Public key exported successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to export public key: {ex.Message}");
            }
        }

        private void buttonImportPrivateKey_Click(object sender, EventArgs e)
        {
            _keyOpenFileDialog.InitialDirectory = KeyFolder;
            _keyOpenFileDialog.Title = "Select Private Key File";
            _keyOpenFileDialog.FileName = string.Empty;

            if (_keyOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string keyFile = _keyOpenFileDialog.FileName;
                    if (!File.Exists(keyFile))
                    {
                        throw new FileNotFoundException("Private key file not found.");
                    }

                    byte[] keyData = File.ReadAllBytes(keyFile);
                    _rsa = new RSACryptoServiceProvider();
                    _rsa.ImportPkcs8PrivateKey(keyData, out _); // Import private key

                    UpdateKeyStatus();
                    MessageBox.Show("Private key imported successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Key import failed: {ex.Message}");
                }
            }
        }

        private void buttonExportPrivateKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rsa == null)
                {
                    MessageBox.Show("Generate or import keys before exporting.");
                    return;
                }

                // Open the SaveFileDialog to allow the user to select a location and file name
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PKCS8 Private Key Files (*.p8)|*.p8|All Files (*.*)|*.*";
                    saveFileDialog.Title = "Save Private Key";
                    saveFileDialog.FileName = "MyPrivateKey";
                    saveFileDialog.InitialDirectory = KeyFolder;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Export private key
                        byte[] privateKeyData = _rsa.ExportPkcs8PrivateKey();
                        File.WriteAllBytes(saveFileDialog.FileName, privateKeyData);
                        MessageBox.Show("Private key exported successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to export private key: {ex.Message}");
            }
        }
    }
}
