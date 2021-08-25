using System;

class MatrixMath
{
    /// <summary>Function to add two matrix</summary>
    /// <param name="matrix1">first matrix</param>
    /// <param name="matrix2">second matrix</param>
    /// <returns>a matrix with the result or matrix with -1 if fail</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] wrong = new double[,] {{-1}};
        if ((matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3) || (matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3) || (matrix1.GetLength(0) != matrix2.GetLength(0)) || (matrix1.GetLength(0) != matrix1.GetLength(1)) || matrix2.GetLength(0) != matrix2.GetLength(1))
            return (wrong);

        double[,] sum = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                sum[i,j] = matrix1[i, j] + matrix2[i, j];
        
        return (sum);
    }
}
