using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vigenere_library;

namespace TestingVigenere
{
    class Program
    {
        static void Main(string[] args)
        {

            string test;

            vig.alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ/?abcdefghijklmnopqrstuvwxyz";

            vig.Capitalize.disable();
            
            test = vig.encrypt("test/?abcABC///?/?", "houston//?");

            Console.WriteLine(test);
            Console.WriteLine(vig.decrypt(test, "houston//?"));

            Console.ReadKey();

        }
    }
}
