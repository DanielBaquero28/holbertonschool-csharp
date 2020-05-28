using System;

/// <summary> MatrixMath Class </summary>
class MatrixMath
{
    /// <summary> Transposes a given matrix </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] r_matrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                r_matrix[i, j] = matrix[j, i];
            }
        }

        return (r_matrix);
    }
}