using System;

namespace MyMath
{
    ///<summary>Performs operations on 2 dimensional matrixies.</summary>
    public class Matrix
    {
        ///<summary>Divides elements in a matrix by a number.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return (null);
            }
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            int mHeight = matrix.GetLength(0);
            int mWidth = matrix.GetLength(1);
            int[,] newMatrix = new int[mHeight, mWidth];
            for (int i = 0; i < mHeight; i++)
            {
                for (int j = 0; j < mWidth; j++)
                {
                    newMatrix[i, j] = matrix[i,j] / num;
                }
            }
            return (newMatrix);
        }
    }
}
