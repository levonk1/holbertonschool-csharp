using System;

class MatrixMath
{
    /// <summary>function to transpose</summary>
    /// <param name="matrix">the matrix</param>
    /// <returns>matrix transpose or empty matrix if fail</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] empt = new double[,] {{ }};
        double[,] res;
        if (matrix.GetLength(0) == 0)
            return empt;
        res = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = 0; j < matrix.GetLength(0); j++)
                res[i, j] = matrix[j, i];
        return res;
    }
}
