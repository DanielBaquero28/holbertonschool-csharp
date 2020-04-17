using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] grid = new int[5,5];
        grid[2,2] = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j < 4)
                    Console.Write("{0} ", grid[i, j]);
                
                else
                    Console.WriteLine("{0}", grid[i, j]);
   
            }
        }
    }
}


