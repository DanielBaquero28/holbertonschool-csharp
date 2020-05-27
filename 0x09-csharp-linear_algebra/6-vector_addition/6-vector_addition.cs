using System;

/// <summary> VectorMath Class </summary>
class VectorMath
{
    /// <summary> Adds two vector </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] f_vector = new double[] {-1};

        if (vector1.Length <= 1 || vector1.Length > 3)
        {
            return (f_vector);
        }

        if (vector2.Length <= 1 || vector2.Length > 3)
        {
            return (f_vector);
        }

        if (vector1.Length != vector2.Length)
        {
            return (f_vector);
        }

        double[] r_vector = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            r_vector[i] = vector1[i] + vector2[i];
        }

        return (r_vector);
    }
}