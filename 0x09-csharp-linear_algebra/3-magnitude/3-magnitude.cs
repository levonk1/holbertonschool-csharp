using System;

class VectorMath {
    /// <summary>Function to get the magnitud of a vector</summary>
    /// <param name="vector"> vector to be multiply</param>
    /// <returns>duble with the magnitude</returns>
    public static double Magnitude(double[] vector) 
    {
        if (vector.Length < 2 || vector.Length > 3)
            return (-1);

        double res = 0;

        for (int i = 0; i < vector.Length; i++) 
        {
            res = res + (vector[i] * vector[i]);
        }
        return (Math.Round(Math.Sqrt(res), 2));
    }
}
