﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name?");
            Console.WriteLine("If you'd like to exit be sure to type 'quit'");
            String Name = Console.ReadLine();
            Console.WriteLine(Name);
            //if (Console.ReadLine("quit" || "QUIT" || "Quit"))
            //{ break;}
            Console.ReadLine();
        }
    }
}
