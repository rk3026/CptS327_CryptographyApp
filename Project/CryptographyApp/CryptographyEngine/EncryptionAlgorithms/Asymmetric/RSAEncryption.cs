using System.Security.Cryptography;
using System.Text;

namespace CryptographyEngine.EncryptionAlgorithms.Asymmetric
{
    public static class RSAEncryption
    {
        public static (byte[] encryptedData, RSAParameters publicKey) Encrypt(string data, RSAParameters publicKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(data);
                byte[] encryptedData = rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.OaepSHA256);
                return (encryptedData, rsa.ExportParameters(false)); // Returns encrypted data and the public key used
            }
        }

        public static string Decrypt(byte[] encryptedData, RSAParameters privateKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                byte[] decryptedData = rsa.Decrypt(encryptedData, RSAEncryptionPadding.OaepSHA256);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }

        public static RSAParameters GenerateKeyPair(int keySize)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.KeySize = keySize;
                return rsa.ExportParameters(true); // Exports both public and private keys
            }
        }
    }
}