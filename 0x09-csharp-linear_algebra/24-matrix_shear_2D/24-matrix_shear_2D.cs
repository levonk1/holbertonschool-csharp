using System;

class MatrixMath
{
    /// <summary>Funtion to share</summary>
    /// <param name="matrix">the matrix</param>
    /// <param name="direction">the direction to rotate</param>
    /// <param name="factor">the factor</param>
    /// <returns>matrix with result or -1 if fail</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] fail = new double[,] { { -1 } };
        double[,] matrix2;
        double operations;
        double[,] result = new double[2, 2];
        if (direction == 'x' || direction == 'y')
        {
            if (direction == 'x')
                matrix2 = new double[,] {{1, 0}, {factor, 1}};
            else
                matrix2 = new double[,] {{1, factor}, {0, 1}};
        }
        else
            return fail;
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return fail;
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                operations = 0;
                for (int k = 0; k < 2; k++)
                    operations = operations + (matrix[i, k] * matrix2[k, j]);
                result[i, j] = operations;
            }
        return result;
    }
}
