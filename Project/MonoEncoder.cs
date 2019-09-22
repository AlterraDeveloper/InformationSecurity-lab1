using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class MonoEncoder : ICryptable
    {
        const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private const string REVERSE_ALPHABET = "ЯЮЭЬЫЪЩШЧЦХФУТСРПОНМЛКЙИЗЖЁЕДГВБАяюэьыъщшчцхфутсрпонмлкйизжёедгвба";
        private static Dictionary<char, char> cryptAlphabet;

        public string Encrypt(string inputText)
        {
            string outputText = string.Empty;

            foreach (var ch in inputText)
            {
                var index = ALPHABET.IndexOf(ch);
                outputText += index < 0 ? ch : REVERSE_ALPHABET.ToCharArray()[index];
            }

            return outputText;
        }

        public string Decrypt(string inputText)
        {
            string outputText = string.Empty;

            foreach (var ch in inputText)
            {
                var index = REVERSE_ALPHABET.IndexOf(ch);
                outputText += index < 0 ? ch : ALPHABET.ToCharArray()[index];
            }

            return outputText;
        }
    }
}
