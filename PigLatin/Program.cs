using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter your word");
            string word1 = Console.ReadLine();
            Console.WriteLine(convert(word1));
        }
        static string convert(string word)
        {
            string first = word.Substring(0, 1);
            string last = word.Substring(word.Length - 2, word.Length);
            Console.WriteLine(first + " " + last);
            char[] vowels = { 'a','e','i','o','u','y',
                                'A','E','I','O','U','Y'};
            string[] vow = { "a", "e", "i", "o", "u", "y" };

        }
     
    }
}
