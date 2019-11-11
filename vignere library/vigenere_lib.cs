using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vigenere_library
{
    static public class vig
    {

        private static string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // I know this is basically unnecesary as it is right now. This is done for later update ability
        public static string alphabet
        {
            get { return _alphabet; }
            set { _alphabet = value; }
        }

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
                if (temp >= alphabet.Length)
                {
                    overFlow = temp - alphabet.Length;
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
                if (temp >= alphabet.Length)
                {
                    overFlow = temp - alphabet.Length;
                    vigOutput += alphabet[overFlow];
                }
                else if (temp < 0)
                {
                    overFlow = alphabet.Length + temp;
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
