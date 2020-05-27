using System;

/// <summary> MatrixMath Class </summary>
class MatrixMath
{
    /// <summary> Adds two matrixes </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] f_matrix = new double[] {{ -1 }};
        if (matrix1.GetLength(0) <= 1 || matrix1.GetLength(0) > 3 || matrix1.GetLength(1) <= 1 || matrix1.GetLength(1) > 3)
        {
            return (f_matrix);
        }

        if (matrix2.GetLength(0) <= 1 || matrix2.GetLength(0) > 3 || matrix2.GetLength(1) <= 1 || matrix2.GetLength(1) > 3)
        {
            return (f_matrix);
        }

        if ((matrix1.GetLength(0) != matrix2.GetLength(0)) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            return (f_matrix);
        }

        double[,] r_matrix = new double[matrix2.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                r_matrix[i][j] = matrix1[i][j] + matrix2[i][j];
            }

            return (r_matrix);
        }
    }
}