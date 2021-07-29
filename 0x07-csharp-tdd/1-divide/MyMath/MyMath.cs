using System;

namespace MyMath
{
    /// <summary> Create a Matrix class </summary>
    public class Matrix
    {
        /// <summary> Representation a Matrix to divide by a number </summary>
        /// <param name="matrix"> the matrix to divide</param>
        /// <param name="num">the num</param>
        /// <returns>Returns a matrix with the divisions</returns>
        public static int[, ] Divide (int[, ] matrix, int num)
        {
            if (matrix == null)
                return null;

            try
            {
                for (int a = 0; a < matrix.GetLength(0); a++) {
                    for (int b = 0; b < matrix.GetLength(1); b++) {
                        matrix[a, b] = matrix[a, b] / num;
                    }
                }
                return matrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine ("Num cannot be 0");
                return null;
            }
        }
    }
}