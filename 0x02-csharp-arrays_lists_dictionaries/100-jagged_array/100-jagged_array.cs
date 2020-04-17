using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4] {0, 1, 2, 3};
        jagged[1] = new int[7] {0, 1, 2, 3, 4, 5, 6};
        jagged[2] = new int[2] {0, 1};

        for (int i = 0; i < jagged.GetLength(0); i++)
        {
            for (int j = 0; j < jagged[i].GetLength(0); j++)
            {
                if (j < (jagged[i].GetLength(0)) - 1)
                {
                    Console.Write("{0} ", jagged[i][j]);
                }
                else
                {
                    Console.WriteLine("{0}", jagged[i][j]);
                }
            }
        }

    }
}

