using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS_Game
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Papper, Rock , or Scissors. The choice is yours");
            string userInput = Console.ReadLine();

            Random rnd = new Random();
            int compInput = rnd.Next(1,4);

            if (compInput == 1)
                {
                    if (userInput == "rock" || "r")
                    {
                    Console.WriteLine("Computer chooses ROCK");
                    Console.WriteLine("Its a DRAW");
                    }
                    else if (userInput == "paper" || "p")
                    {
                    Console.WriteLine("Computer chooses ROCK");
                    Console.WriteLine("Paper beats Rock! You Win!");
                    }
                    else if (userInput == "scissor" || "s")
                    {
                    Console.WriteLine("Computer chooses ROCK");
                    Console.WriteLine("Rock beats scissors! You Lose!");
                    }
                else 
                {
                    Console.WriteLine("You must pick u prick");
                }
                }
            else if (compInput == 2)
                {
                    if (userInput == "rock" || "r")
                    {
                    Console.WriteLine("Computer chooses PAPER");
                    Console.WriteLine("Paper beats rock! You Lose!");
                    }
                    else if (userInput == "paper" || "p")
                    {
                    Console.WriteLine("Computer chooses PAPER");
                    Console.WriteLine("Its a DRAW");
                    }
                    else if (userInput == "scissor" || "s")
                    {
                    Console.WriteLine("Computer chooses PAPER");
                    Console.WriteLine("Scissors beat paper! You Win!");
                    }
                else 
                {
                    Console.WriteLine("You must pick u prick");
                }
                }
            else if (compInput == 3)
                {
                    if (userInput == "rock" || "r")
                    {
                    Console.WriteLine("Computer chooses SCISSORS");
                    Console.WriteLine("Rock beats scissors! You Win!");
                    }
                    else if (userInput == "paper" || "p")
                    {
                    Console.WriteLine("Computer chooses SCISSORS");
                    Console.WriteLine("Scissors beats paper! You Lose!");
                    }
                    else if (userInput == "scissor" || "s")
                    {
                    Console.WriteLine("Computer chooses SCISSORS");
                    Console.WriteLine("Its a DRAW");
                    }
                else 
                {
                    Console.WriteLine("You must pick u prick");
                }
             }
           
            Console.ReadLine();
        }
    }
}
