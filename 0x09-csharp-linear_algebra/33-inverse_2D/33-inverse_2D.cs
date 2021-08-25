using System;

class MatrixMath
{
    /// <summary>Function to inverse a matrix</summary>
    /// <param name="matrix">the mtrix</param>
    /// <returns>matrix inverse or -1 if fail</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double deter;
        double [,] wrong = new double[,] {{-1}};
        double [,] inverse = new double[2, 2];
        double [,] transpose = new double[2, 2];
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return wrong;
        transpose[0, 0] = matrix[1, 1];
        transpose[0, 1] = -1 * matrix[0, 1];
        transpose[1, 0] = -1 * matrix[1, 0];
        transpose[1, 1] = matrix[0, 0];

        deter = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);

        if (deter == 0)
            return wrong;

        double divDet = 1 / deter;

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                inverse[i, j] = Math.Round(divDet * transpose[i, j], 2);
    
        return inverse;
    }
}