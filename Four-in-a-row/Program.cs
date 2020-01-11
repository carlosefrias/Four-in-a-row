using System;

namespace Four_in_a_row
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var board = new Board();
            board.Play(1, 3);
            board.Play(2, 3);
            board.Play(1, 2);
            board.Play(2, 3);
            board.PrintBoard();
        }
    }
}