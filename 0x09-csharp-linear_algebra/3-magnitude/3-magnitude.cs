using System;

/// <summary> VectorMath Class </summary>
class VectorMath
{
    /// <summary> Finds magnitude (length) of a vector </summary>
    public static double Magnitude(double[] vector)
    {
        double mag = 0;

        if (vector.Length <= 1 || vector.Length > 3)
        {
            return (-1);
        }
        
        for (int i = 0; i < vector.Length; i++)
        {
            mag += vector[i] * vector[i];
        }

        mag = Math.Sqrt(mag);

        return (Math.Round(mag, 2));
    }
}
