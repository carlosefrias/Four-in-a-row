using System.Collections.Generic;
using System.Linq;

namespace Four_in_a_row.Extensions
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Returns all elements on specified column
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="columnNumber"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetColumn<T>(this T[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                .Select(x => matrix[x, columnNumber]);
        }

        /// <summary>
        /// Returns all elements on specified row
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rowNumber"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetRow<T>(this T[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                .Select(x => matrix[rowNumber, x]);
        }
    }
}