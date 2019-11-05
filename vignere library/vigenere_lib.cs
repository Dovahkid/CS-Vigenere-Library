using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vigenere_library
{
    static public class vig
    {
        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static public string encrypt(string plainText, string key)
        {
            
            int temp;
            int overFlow;
            string vigOutput = "";

            plainText = plainText.ToUpper();
            key = key.ToUpper();

            for (int i = 0; i <= plainText.Length - 1; i++)
            {
                temp = alphabet.IndexOf(key[i % key.Length]) + alphabet.IndexOf(plainText[i]);
                if (temp >= 26)
                {
                    overFlow = temp - 26;
                    vigOutput += alphabet[overFlow];
                }
                else
                {
                    vigOutput += alphabet[temp];
                }

            }

            return vigOutput;
        }

        static public string decrypt(string plainText, string key)
        {
            int temp;
            int overFlow;
            string vigOutput = "";

            plainText = plainText.ToUpper();
            key = key.ToUpper();

            for (int i = 0; i <= plainText.Length - 1; i++)
            {
                temp = alphabet.IndexOf(plainText[i]) - alphabet.IndexOf(key[i % key.Length]);
                if (temp >= 26)
                {
                    overFlow = temp - 26;
                    vigOutput += alphabet[overFlow];
                }
                else if (temp < 0)
                {
                    overFlow = 26 + temp;
                    vigOutput += alphabet[overFlow];
                }
                else
                {
                    vigOutput += alphabet[temp];
                }

            }

            return vigOutput;

        }

    }
}
