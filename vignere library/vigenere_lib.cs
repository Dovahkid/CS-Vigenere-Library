using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vigenere_library
{
    static public class vig
    {
        public static string alphabet { get; set; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static class Capitalize // This was added to support more characters. Change was made to support the password manager and similar projects with similar requirements
        {
            public static bool isCapital = true;
            static public void enable()
            { isCapital = true; }

            static public void disable()
            { isCapital = false; }
        }

        static public string encrypt(string plainText, string key)
        {

            int temp;
            int overFlow;
            StringBuilder sb = new StringBuilder();

            if (Capitalize.isCapital) // a normal vigenere cipher requires the input to be uppercase. This makes sure the input is turned to uppercase if a new alphabet is provided that does not require uppercase
            {
                plainText = plainText.ToUpper();
                key = key.ToUpper();
            }

            for (int i = 0; i <= plainText.Length - 1; i++)
            {
                temp = alphabet.IndexOf(key[i % key.Length]) + alphabet.IndexOf(plainText[i]);
                if (temp >= alphabet.Length)
                {
                    overFlow = temp - alphabet.Length;
                    sb.Append(alphabet[overFlow]);
                }
                else
                {
                    sb.Append(alphabet[temp]);
                }

            }

            return sb.ToString();
        }

        static public string decrypt(string plainText, string key)
        {
            int temp;
            int overFlow;
            StringBuilder sb = new StringBuilder();

            if (Capitalize.isCapital) // a normal vigenere cipher requires the input to be uppercase. This makes sure the input is turned to uppercase if a new alphabet is provided that does not require uppercase
            {
                plainText = plainText.ToUpper();
                key = key.ToUpper();
            }

            for (int i = 0; i <= plainText.Length - 1; i++)
            {
                temp = alphabet.IndexOf(plainText[i]) - alphabet.IndexOf(key[i % key.Length]);
                if (temp >= alphabet.Length)
                {
                    overFlow = temp - alphabet.Length;
                    sb.Append(alphabet[overFlow]);
                }
                else if (temp < 0)
                {
                    overFlow = alphabet.Length + temp;
                    sb.Append(alphabet[overFlow]);
                }
                else
                {
                    sb.Append(alphabet[temp]);
                }

            }

            return sb.ToString();
        }

    }
}
