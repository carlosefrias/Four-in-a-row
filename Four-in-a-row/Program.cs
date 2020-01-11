using System;

namespace Four_in_a_row
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var board = new Board();
            board.InitializeBoard();
            board.PrintBoard();
        }
    }
}