using System.Security.Cryptography;
using System.Text;

namespace CryptographyEngine.HashingAlgorithms
{
    public static class SHA256Hashing
    {
        public static byte[] ComputeHash(string data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
            }
        }
    }
}
