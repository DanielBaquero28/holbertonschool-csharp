using System;

/// <summary> VectorMath Class </summary>
class VectorMath
{
    /// <summary> Multiplies a vector by a scalar </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length <= 1 || vector.Length > 3)
        {
            return (-1);
        }

        double[] r_vector = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            r_vector[i] = vector[i] * scalar;
        }

        return (r_vector);
    }
}