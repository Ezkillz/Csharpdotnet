using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word");
            string word1 = Console.ReadLine();
            Console.WriteLine(convert(word1));
            Console.ReadLine();
        }
        static string convert(string word)
        {
            string ret = "";
            string first = word.Substring(0, 1);
            string last = word.Substring(word.Length - 1);
            //string all = word.Substring(word);
            //string all = word.IndexOfAny(char[]anyOf); <-- wrong!/wont work :(
            char[] vowels = { 'a','e','i','o','u','y',
                                'A','E','I','O','U','Y'};
            string[] vow = { "a", "e", "i", "o", "u", "y" };
            string[] conis = { "b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","t","v","w","x","z"};
            if (vow.Contains(first) && vow.Contains(last))
            {
                ret = word + "yay";
            }
            else if (vow.Contains(first) && conis.Contains(last))
            {
                ret = word + "ay";
            }
            else if (word.IndexOfAny(vowels) == -1)
            {
                ret = word + "ay";
            }
            else if (conis.Contains(first) &&  word.IndexOfAny(vowels) > -1)
            {
                int voIndex = word.IndexOfAny(vowels);
                string A1 = word.Substring(0 , voIndex);
                string A2 = word.Substring(voIndex);
                ret = A2 + A1 + "ay" ;

            }



            return ret;
        }

    }
}
