using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    public class CaesarEncoder : ICryptable
    {
        private int cryptKey;
        const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public CaesarEncoder(int cryptKey = 1)
        {
            this.cryptKey = cryptKey;
        }

        public string Encrypt(string inputText)
        {
            var outputText = string.Empty;
            var fullAlphabet = ALPHABET + ALPHABET.ToLower();
            var fullAlphabetLength = fullAlphabet.Length;

            foreach (var ch in inputText)
            {
                var index = fullAlphabet.IndexOf(ch);
                if (index < 0)
                {
                    outputText += ch;
                }
                else
                {
                    outputText += fullAlphabet[(fullAlphabetLength + index + cryptKey) % fullAlphabetLength];
                }
            }

            return outputText;
        }
    }
}
