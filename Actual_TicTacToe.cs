using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actual_TicTacToe
{
    class Program
    {
        public static string[,] board = new string[3, 3];
        public static bool isGameOver = false;
        public static bool xTurn = true;
        public static string winner; 
        static void Main(string[] args)
        {
            for( int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i, j] = " ";
                }
            }
            
            while (!isGameOver)
            {
                printBoard();
                int[] move = getInput();
                board[move[0], move[1]] = getTurn();
                checkWin();
            }
            printBoard();
            Console.WriteLine($"winner is {winner}");
            Console.ReadLine();

        }
        public static void printBoard()
        {
            Console.WriteLine("  1  2  3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{board[i, j]}]");
                }
                Console.WriteLine();
            }

        }
        public static int[] getInput()
        {
            Console.WriteLine("Enter your move (col row)");
            string rawMove = Console.ReadLine();
            string[] rawMoves = rawMove.Split(' ');
            int[] move = new int[2];
            move[1] = Convert.ToInt32(rawMoves[0]) - 1;
            move[0] = Convert.ToInt32(rawMoves[1]) - 1;
            return move;
        }
        public static string getTurn()
        {
            if( xTurn)
            {
                xTurn = !xTurn;
                return "X";
            }
            else
            {
                xTurn = !xTurn;
                return "O";
            }
        }
        public static void checkWin()
        {
            // check each row 
            int count;
            for( int i = 0; i < 3; i++)
            {
                count = 0;
                for(int j = 0; j < 3; j++)
                {
                    if(board [i , j] == "X")
                    {
                        count++;
                    }
                    if(board [i , j] == "O")
                    {
                        count--;
                    }
                }
                if(count == 3)
                {
                    isGameOver = true;
                    winner = "X";
                }
                if(count == -3)
                {
                    isGameOver = true;
                    winner = "O";
                }
            }

            //Check columns
            for (int i = 0; i < 3; i++)
            {
                count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (board[j,i] == "X")
                    {
                        count++;
                    }
                    if (board[j,i] == "O")
                    {
                        count--;
                    }
                }
                if (count == 3)
                {
                    isGameOver = true;
                    winner = "X";
                }
                if (count == -3)
                {
                    isGameOver = true;
                    winner = "O";
                }
            }

            if(board[0,0] == board[2,2] && board[1,1]== board[2,2] && board[0,0] != " ")
            {
                if(board[0,0] == "X")
                {
                    isGameOver = true;
                    winner = "X";
                }
                if(board[0,0] == "O")
                {
                    isGameOver = true;
                    winner = "O";
                }
            }
            if(board[0,2] == board[1,1] && board [2,0] == board[1,1] && board[1,1] !=" ")
            {
                if (board[2, 0] == "X")
                {
                    isGameOver = true;
                    winner = "X";
                }
                if (board[2, 0] == "O")
                {
                    isGameOver = true;
                    winner = "O";
                }
            }





        }
    }

}
