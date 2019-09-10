using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TritemiusEncoder : ICryptable
    {
        private string cryptWord;
        const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public TritemiusEncoder(string key)
        {
            if (key == string.Empty) cryptWord = "тритемиус";
            else cryptWord = key;
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
                    outputText +=
                        fullAlphabet[
                            (index + fullAlphabet.IndexOf(cryptWord[index % cryptWord.Length])) % fullAlphabetLength];
                }
            }

            return outputText;
        }
    }
}
