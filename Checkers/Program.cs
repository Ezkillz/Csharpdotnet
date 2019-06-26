using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public struct Position
{
    public int row { get; private set; }
    public int col { get; private set; }
    public Position(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}

public enum Color { White, Black }

public class Checker
{
    public String symbol { get; private set; }
    public Color team { get; private set; }
    public Position position { get; set; }

    public Checker(Color team, int row, int col)
    {
        // ...  
    }

}

public class Board
{
    public List<Checker> checkers;
    public Board()
    {
        checkers = new List<Checker>();
        for (int r = 0; r < 3; r++)
        {
            for (int i = 0; i < 8; i += 2)
            {
                Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                checkers.Add(c);
            }
            for (int i = 0; i < 8; i += 2)
            {
                Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                checkers.Add(c);
            }
        }
    }

    public Checker GetChecker(Position pos)
    {
        //..
    }

    public void RemoveChecker(Checker checker)
    {
        // ...
    }

    public void MoveChecker(Checker checker, Position dest)
    {
        // ..
    }

}

public class Game
{
    private Board board;
    public Game()
    {
        this.board = new Board();
    }

    private bool CheckForWin()
    {
        // ..
    }

    public void Start()
    {
        // ...
    }

    public bool IsLegalMove(Color player, Position src, Position dest)
    {
        // ...        
    }

    public bool IsCapture(Position src, Position dest)
    {
        // ...
    }

    public Checker GetCaptureChecker(Position src, Position dest)
    {
        // ..
    }

    public Position ProcessInput()
    {
        // ...
    }

    public void DrawBoard()
    {
        String[][] grid = new String[8][];
        for (int r = 0; r < 8; r++)
        {
            grid[r] = new String[8];
            for (int c = 0; c < 8; c++)
            {
                grid[r][c] = " ";
            }
        }
        foreach (Checker c in board.checkers)
        {
            grid[c.position.row][c.position.col] = c.symbol;
        }

        Console.WriteLine("  0 1 2 3 4 5 6 7");
        for (int r = 0; r < 8; r++)
        {
            Console.Write(r);
            for (int c = 0; c < 8; c++)
            {
                Console.Write(" {0}", grid[r][c]);
            }
            Console.WriteLine();
        }
    }


}
// int rowDistance = Math.Abs(destination.Row - source.Row);
    // int colDist = Math.Abs(destination.Col - );
    //
    // if (colDistance == 0|| rowDist ==0) return false;
    // if (row Dist == 0 || colDist != 1 ) ret false;

    // if (c == null) {return false;}
    // if (c == null) return false;

    // if (player == Color.White) {
    // if (destination.column > source.column )
    // if (rowDistance == 2){ if (isCapture(player, source , destination)) { int row_mid = (destination.Column + src.col) /2;
    // int col_mid = ( destination.col + src.col) / 2; position p = new Position(row_mid, col_mid)
class Program
{
    public static void Main(String[] args)
    {
        Game game = new Game();
        game.Start();
    }
}

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Checkers
    {
        public string Symbol { get; private set; };
        public Color Team { get; private set; };
        public Position Position { get; set; };
    }
    public enum Color
    {

    }
    public struct Positions
    {
        public int Row { get; set; };
        public int column { get; set; };
    }
    public Checker(Color team, int row, int col)
    {
        if (team == color.black)
        {
            Symbol = "25CF";
            team = color.white;
        }
        else
        {
            symbol = "25CB";
            team = color.black;
        }
    }
    class something
    {
        this.row = row;
        this.column = column ;
    }
    public bool IsLegalMOve(ColorPlayer, Position source, Positions destination)
    {
        if (source.Row < 0 || source.row > 7 || source.column < 0 || source.column > 7) ;

    }

    //checker srcChecker= board.GetChecker(from);
    //if (srcChecker == null)
    // { console.WriteLine("Invalide move"); }
    //else
    // { if (this.isLegalMove(srcChecker.Team, from , to))
    //   { if (this.IsCapture( from , to))
    //     { Checker capturedChecker = this.GetCaptureChecker(from , to ) ; } 
    //     board.MoveChecker() ;
    //   }     
    // } 

    ///// remove checker   //////
        // board.RemoveChecker(CapturedChecker);
        //
        // board.MoveChecker(srcChecker, to)
