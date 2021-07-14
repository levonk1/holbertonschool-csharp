using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        for (int x = 0; x < myMatrix.GetLength(0); x++)
        {
            for (int y = 0; y < myMatrix.GetLength(1); y++)
            {
                myMatrix[x, y] *= myMatrix[x, y];
            }
        }
        return myMatrix;
    }
}