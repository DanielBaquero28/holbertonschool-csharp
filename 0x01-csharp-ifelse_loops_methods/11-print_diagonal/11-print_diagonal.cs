using System;
class Line
{
    public static void PrintDiagonal(int Length)
    {
        int i, j;
        for (i = 0; i < Length; i++)
        {
            for (j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        Console.Write("\n");
    }
}