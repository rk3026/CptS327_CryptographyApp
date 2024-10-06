using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEngine.HashingAlgorithms
{
    public static class SHA512Hashing
    {
        public static byte[] ComputeHash(string data)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(Encoding.UTF8.GetBytes(data));
            }
        }
    }
}
