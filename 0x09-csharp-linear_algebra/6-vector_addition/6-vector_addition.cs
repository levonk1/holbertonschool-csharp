using System;

class VectorMath 
{
    /// <summary>Function to add two vectors</summary>
    /// <param name="vector1">first vector to be sum</param>
    /// <param name="vector2">second vector to be sum</param>
    /// <returns>the sum of the two vectors or -1 if fail</returns>
    public static double[] Add(double[] vector1, double[] vector2) 
    {
        double[] wrong = new double[1] {-1};
        if ((vector1.Length < 2 || vector1.Length > 3) && (vector2.Length < 2 || vector2.Length > 3) || (vector1.Length != vector2.Length))
        {
            return (wrong);
        }
        double[] sum = new double[vector1.Length];

        for (int i = 0; i < vector1.Length && i < vector2.Length; i++)
        {
            sum[i] = vector1[i] + vector2[i];
        }
        return (sum);
    }
}