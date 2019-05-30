using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void main(string[] args)
        {
            char[,] board = new char[3, 3];
            gameName();
            boardLayout();
            Console.ReadLine();
            
        }
        static void gameName()
        {
            Console.WriteLine("T1C - T4C - T0E");

        }
        static void boardLayout()
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("|");
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("| X ");
                }
            }
        }
        static void placeMark()
        {
            //(int RowPos, int ColPos);
            //int RowIdx = RowPos -1;
            // board [RowIdx, ColIdx] = CurrentPlayer;
            //PrintBoard ();
        }
    }
}
