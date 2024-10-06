using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEngine.HashingAlgorithms
{
    public static class MD5Hashing
    {
        public static byte[] ComputeHash(string data)
        {
            using (MD5 md5 = MD5.Create())
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(data));
            }
        }
    }
}
