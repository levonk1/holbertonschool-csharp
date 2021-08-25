using System;

class VectorMath
{
    /// <summary>Function to multiply a vector by an scalar</summary>
    /// <param name="vector">the vector to be multiplied</param>
    /// <param name="scalar">the scalar to multiply</param>
    /// <returns>double[] with teh answer or -1 if fails</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] wrong = new double[1] {-1};
        if ((vector.Length < 2 || vector.Length > 3))
            return (wrong);

        double[] mul = new double[vector.Length];

        for (int i = 0; i < vector.Length; i++)
        {
            mul[i] = vector[i] * scalar;
        }
        return (mul);
    }
}
