using System;

namespace MyMath
{
    /// <summary> Matrix Class </summary>
    public class Matrix
    {
        /// <summary> Divides each of elements in the matrix by num </summary>
        /// <returns> A new matrix with it's elements divided previosly </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return (null);

            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        newMatrix[i,j] = matrix[i,j] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }

            return (newMatrix);
        }
    }
}
