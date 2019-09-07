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

        public MonoEncoder()
        {
            cryptAlphabet = new Dictionary<char, char>();
            for (int i = 0; i < ALPHABET.Length; i++)
            {
                cryptAlphabet.Add(ALPHABET[i],REVERSE_ALPHABET[i]);
            }       
        }

        public string Encrypt(string inputText)
        {
            string outputText = string.Empty;

            foreach (var ch in inputText)
            {
                try
                {
                    outputText += cryptAlphabet[ch];
                }
                catch (KeyNotFoundException ex)
                {
                    outputText += ch;
                }
                
            }
            return outputText;
        }
    }
}
