using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            hello();
            addition();
            catDog();
            oddEven();
            inches();

            date();
            Console.ReadLine();
        }
        public static void hello()
        {
            Console.WriteLine("hello what is your name?");
            String Name = Console.ReadLine();
            Console.WriteLine( "Wow " + Name + " is a sorry name");
        }
        public static void addition()
        {
            Console.WriteLine("Enter 2 numbers and I'll save you the effort:)");
            String first = Console.ReadLine();
            int num1 = Convert.ToInt32(first);
            first = Console.ReadLine();
            int num2 = Convert.ToInt32(first);
            Console.WriteLine(num1 + num2);
        }
        public static void catDog()
        {
            Console.WriteLine("Do you perfer a cat or a dog?");
            String one = Console.ReadLine();
            if (one == "cat")
            {
                Console.WriteLine("MEOW");
            }
            else if (one == "dog")
            {
                Console.WriteLine("WOOLF");
            }
        }
        public static void oddEven()
        {
            Console.WriteLine("Choose any 2 digit number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("Thats an Even #");
            }
            else if(num % 2 == 1)
            {
                Console.WriteLine("Thats an Odd #");
            }
        }
        public static void inches()
        {
            Console.WriteLine("Enter your height number to the closest feet:");
            int feet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(feet * 12);
        }
        public static void echo()
        {
            Console.WriteLine("Say something. I dare you!");
            string wow = Console.ReadLine();
            Console.WriteLine(wow.ToUpper());  
            Console.WriteLine(wow.ToLower());
            Console.WriteLine(wow.ToLower());
        }
        public static void killGram()
        {
            Console.WriteLine("How many pounds do you weigh?");
            int pound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pound * 0.453);
        }
        public static void date()
        {
            Console.WriteLine("Would you like to know todays date? Y or N ");
            DateTime Name = DateTime.Now;
            String fu = Console.ReadLine();
            if ( fu == "y" )
            { 
                Console.WriteLine("Todays date is:");
                Console.WriteLine(Name.ToLongDateString());
                Console.WriteLine(Name.ToShortTimeString());
            }
            else if ( fu == "n")
            {
                Console.WriteLine("Welp to bad ...");
                Console.WriteLine(Name.ToShortDateString() + " " + Name.ToLongTimeString());
            }
        }
    }
}
