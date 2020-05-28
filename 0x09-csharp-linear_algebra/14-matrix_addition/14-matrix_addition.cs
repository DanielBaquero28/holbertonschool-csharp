using System;

/// <summary> MatrixMath Class </summary>
class MatrixMath
{
    /// <summary> Adds two matrixes </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] f_matrix = {{-1}};
        double[,] r_matrix;
        int mx1 = matrix1.GetLength(0);
        int my1 = matrix1.GetLength(1);
        int mx2 = matrix2.GetLength(0);
        int my2 = matrix2.GetLength(1);

        if (mx1 == 2 && my1 == 2 && mx1 == mx2 && my1 == my2)
        {
            r_matrix = new double[2, 2];
        }
        else if (mx1 == 3 && my1 == 3 && mx1 == mx2 && my1 == my2 )
        {
            r_matrix = new double[3, 3];
        }
        else
        {
            return (f_matrix);
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                r_matrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }

        }

        return (r_matrix);
    }
}