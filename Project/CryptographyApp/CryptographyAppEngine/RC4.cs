﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyAppEngine
{
    public class RC4
    {
        private byte[] S = new byte[256]; // The state array
        private int x = 0, y = 0; // Indicies for Pseudo-Random Generation and Key Scheduling

        public RC4()
        {
            for (int i = 0; i < 256; i++)
                S[i] = (byte)i;
        }

        public byte[] Encrypt(byte[] data, byte[] key)
        {
            KeySetup(key);
            byte[] output = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                output[i] = (byte)(data[i] ^ GenerateKeystreamByte());
            }

            return output;
        }

        public byte[] Decrypt(byte[] data, byte[] key)
        {
            return Encrypt(data, key); // Same method is used for encryption and decryption
        }


        private void KeySetup(byte[] key)
        {
            // Reset x and y
            x = 0;
            y = 0;

            // Reset S to the initial permutation
            for (int i = 0; i < 256; i++)
            {
                S[i] = (byte)i;
            }

            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + key[i % key.Length]) % 256;
                Swap(i, j);
            }
        }


        private byte GenerateKeystreamByte()
        {
            x = (x + 1) % 256;
            y = (y + S[x]) % 256;
            Swap(x, y);
            return S[(S[x] + S[y]) % 256];
        }

        private void Swap(int a, int b)
        {
            byte temp = S[a];
            S[a] = S[b];
            S[b] = temp;
        }
    }

}
