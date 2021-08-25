using System;

class MatrixMath
{
    /// <summary>Funtion to multiply two matrix</summary>
    /// <param name="matrix1">first matrix</param>
    /// <param name="matrix2">second matrix</param>
    /// <returns>matrix with result or matrix with -1 if fail</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] wrong = new double[,] {{-1}};
        double oper;
        double[,] mul;

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return wrong;
        else
            mul = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    oper = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                        oper = oper + matrix1[i, k] * matrix2[k, j];
                    mul[i, j] = oper;
                }
        return (mul);
    }
}
