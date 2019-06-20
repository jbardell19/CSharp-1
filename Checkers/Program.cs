using System;
using System.Collections.Generic;

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
    public String Symbol { get; private set; }
    public Color Team { get; private set; }
    public Position Position { get; set; }
    #region CLASS CHECKER
    public Checker(Color team, int row, int col)
    {
        if (team == Color.White)
        {
            Symbol = "25CF";
            Team = Color.White;
        }
        else
        {
            Symbol = "25CB";
            Team = Color.Black;
        }
    }

}
#endregion
#region CLASS BOARD
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
        foreach (Checker c in checkers)
        {
            if (c.Position.row == source.Row && c.Position.Column == source.Column)
        }
    }

    public void RemoveChecker(Checker checker)
    {
        // ...
    }

    public void MoveChecker(Checker checker, Position dest)
    {
        // move the checker from one location to another
    }

}
#endregion
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
        if (src.Row < 0 || src.row > 7 || src.Column < 0 || src.Column > 7
            || dest.Row < 0 || dest.Row > 7 || dest.Column < 0 || dest.Column > 7)
            return false;

        int rowDistance = Math.Abs(dest.row - src.Row);
        int colDistance = Math.Abs(dest.Column - src.Column);
        //make sure the denominator is equal to zero
        if (colDistance == 0 || rowDistance == 0) return false;
        if (rowDistance / colDistance != 1)
            return false;
        if (rowDistance > 2) return false;

        Checker c = board.GetChecker(src);
        if (c != null) return false;

        if (player == Color.White)
        {
            if (dest.row - src.row == 2)
            {
                if (dest.Column > src.col)
                {

                }
            }
        }
    }

    public bool IsCapture(Position src, Position dest)
    {
        int rowDistance = Math.Abs(dest.Row - src.row) / 2;
        int colDistance = Math.Abs(dest.col - src.col) / 2;


    }

    public Checker GetCaptureChecker(Position src, Position dest)
    {
        if (IsCapture(player, src, dest)
            {
            int row_mid = (dest.row + src.Row) / 2;
            int col_mid = (dest.col + src.col) / 2;
            Position p = new Position(row_mid, col_mid);
            Checker c = board.GetChecker(p);
            return c;
        }
        return null;
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
            grid[c.Position.row][c.Position.col] = c.Symbol;
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

class Program
{
    public static void Main(String[] args)
    {
        Game game = new Game();
        game.Start();
    }
}