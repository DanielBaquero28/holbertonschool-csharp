using System;

/// <summary> VectorMath Class </summary>
class VectorMath
{
    /// <summary> Multiplies a vector by a scalar </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] f_vector = new double[] {-1};
        if (vector.Length <= 1 || vector.Length > 3)
        {
            return (f_vector);
        }

        double[] r_vector = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            r_vector[i] = vector[i] * scalar;
        }

        return (r_vector);
    }
}