using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class FrequentCounter
    {
        const string ALPHABET = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static Dictionary<char, int> countAppearencesOfLetter(string text)
        {
            var freqDict = new Dictionary<char,int>(ALPHABET.Length);
            var lowerText = text.ToLower();

            foreach (var ch in ALPHABET)
            {
                freqDict[ch] = 0;
            }

            foreach (var letter in lowerText)
            {
                if (ALPHABET.Contains(letter.ToString()))
                {
                    var counter = lowerText.Count(ch => ch == letter);
                    freqDict[letter] = counter;
                }
                
            }

            return freqDict;
        }
    }
}
