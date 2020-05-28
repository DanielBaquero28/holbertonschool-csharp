using System;

/// <summary> MatrixMath Class </summary>
class MatrixMath
{
    /// <summary> Rotate a 2D matrix by angle in radians </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] f_matrix = {{-1}};
        double[,] r_matrix = new double[2, 2];

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return (f_matrix);
        }

        double[,] rotate_matrix = {{Math.Cos(angle), Math.Sin(angle)}, {Math.Sin(angle) * -1, Math.Cos(angle)}};
        double result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    result += Math.Round(matrix[i, k] * rotate_matrix[k, j], 2);
                }

                r_matrix[i, j] = result;
            }
        }

        return (r_matrix);
    }
}