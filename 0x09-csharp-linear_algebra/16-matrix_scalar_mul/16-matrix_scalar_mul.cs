using System;

/// <summary> MatrixMath Class </summary>
class MatrixMath
{
    /// <summary> Multiplies a matrix by a scalar </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] f_matrix = {{-1}};
        double[,] r_matrix;
        int mx1 = matrix.GetLength(0);
        int my1 = matrix.GetLength(1);

        if (mx1 == 2 && my1 == 2)
        {
            r_matrix = new double[2, 2];
        }
        else if (mx1 == 3 && my1 == 3)
        {
            r_matrix = new double[3, 3];
        }
        else
        {
            return (f_matrix);
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                r_matrix[i, j] = matrix[i, j] * scalar;
            }

        }

        return (r_matrix);
    } 
}