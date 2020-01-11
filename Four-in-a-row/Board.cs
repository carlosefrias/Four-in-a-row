using System;
using System.Linq;
using System.Text;
using Four_in_a_row.Extensions;

namespace Four_in_a_row
{
    public class Board
    {
        #region public fields

        

        #endregion

        #region private fields
        
        private Cell[,] _boardValues = new Cell[Constants.NumberOfRows,Constants.NumberOfColumns];

        #endregion

        #region Constructors
        
        public Board()
        {
            InitializeBoard();
        }
        
        #endregion
        
        
        private void InitializeBoard()
        {
            for (var row = 0; row < Constants.NumberOfRows; row++)
            {
                for (var column = 0; column < Constants.NumberOfColumns; column++)
                {
                    _boardValues[row, column] = new Cell(0);
                }
            }
        }

        public void ClearBoard()
        {
            foreach (var cell in _boardValues)
            {
                cell.CellValue = 0;
            }
        }
        
        
        public bool Play(int player, int column)
        {
            if(player != 1 && player != 2) return false;
            if (column < 1 || column > Constants.NumberOfColumns) return false;
            column -= 1;
            
            //Get position on column where to place player's peace
            var rowIdx = _boardValues.GetColumn(column).ToList().FindLastIndex(item => item.CellValue == 0);
            if (rowIdx == -1) return false;
            _boardValues[rowIdx, column].CellValue = player;
            return true;
        }
        
        public void PrintBoard()
        {
            const string topAndBottom = "|1|2|3|4|5|6|7|\n|=|=|=|=|=|=|=|\n";
            
            var stringBuilder = new StringBuilder(topAndBottom);

            for (var row = 0; row < Constants.NumberOfRows; row++)
            {
                stringBuilder.Append('|');
                for (var column = 0; column < Constants.NumberOfColumns; column++)
                {
                    stringBuilder.Append(_boardValues[row, column] + "|");
                }

                stringBuilder.Append('\n');
            }

            stringBuilder.Append(topAndBottom);
            
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