using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEngine.EncryptionAlgorithms.Symmetric.BlockCiphers
{
    public static class DESEncryption
    {
        public static byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (DES des = DES.Create())
            {
                des.Key = key;
                des.IV = iv;

                using (var encryptor = des.CreateEncryptor(des.Key, des.IV))
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(data, 0, data.Length);
                        csEncrypt.FlushFinalBlock();
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        public static byte[] Decrypt(byte[] encryptedData, byte[] key, byte[] iv)
        {
            using (DES des = DES.Create())
            {
                des.Key = key;
                des.IV = iv;

                using (var decryptor = des.CreateDecryptor(des.Key, des.IV))
                using (var msDecrypt = new MemoryStream(encryptedData))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var resultStream = new MemoryStream())
                {
                    csDecrypt.CopyTo(resultStream);
                    return resultStream.ToArray();
                }
            }
        }
    }
}
