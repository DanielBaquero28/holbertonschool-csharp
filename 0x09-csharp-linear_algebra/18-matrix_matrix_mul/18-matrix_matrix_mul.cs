using System;

/// <summary> MatrixMath Class </summary>
class MatrixMath
{
    /// <summary> Multiplies two matrixes together </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] f_matrix = {{-1}};
        double[,] r_matrix;
        int mx1 = matrix1.GetLength(0);
        int my1 = matrix1.GetLength(1);
        int mx2 = matrix2.GetLength(0);
        int my2 = matrix2.GetLength(1);

        if (my1 == mx2)
        {
            r_matrix = new double[mx1, my2];
        }
        else
        {
            return (f_matrix);
        }

        double result = 0;
        for (int i = 0; i < r_matrix.GetLength(0); i++)
        {
            for (int j = 0; j < r_matrix.GetLength(1); j++)
            {
                result = 0;
                for (int k = 0; k < mx2; k++)
                {
                    result += matrix1[i, k] * matrix2[k, j];
                }

                r_matrix[i, j] = result;
            }
        }

        return (r_matrix);

    }
}