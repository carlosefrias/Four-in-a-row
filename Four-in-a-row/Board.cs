using System;
using System.Text;

namespace Four_in_a_row
{
    public class Board
    {
        private readonly Cell[,] _boardValues = new Cell[Constants.NumberOfRows,Constants.NumberOfColumns];

        public void InitializeBoard()
        {
            for (var row = 0; row < Constants.NumberOfRows; row++)
            {
                for (var column = 0; column < Constants.NumberOfColumns; column++)
                {
                    _boardValues[row, column] = new Cell(0);
                }
            }
        }


        public void PrintBoard()
        {
            var stringBuilder = new StringBuilder();

            for (var row = 0; row < Constants.NumberOfRows; row++)
            {
                stringBuilder.Append('|');
                for (var column = 0; column < Constants.NumberOfColumns; column++)
                {
                    stringBuilder.Append(_boardValues[row, column] + "|");
                }

                stringBuilder.Append('\n');
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }

    public class Cell
    {
        public int CellValue; //0-empty, 1-player1, 2-player2

        public Cell(int cellValue)
        {
            CellValue = cellValue;
        }
        
        public override string ToString()
        {
            switch (CellValue)
            {
                case 1:
                    return "X";
                case 2:
                    return "O";
                default:
                    return " ";
            }
        }
    }
}