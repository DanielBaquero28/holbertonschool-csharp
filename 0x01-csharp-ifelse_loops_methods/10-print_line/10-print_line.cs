using System;
class Line
{
    public static void PrintLine(int Length)
    {
        int i;

        for (i = 0; i <= Length; i++)
        {
            Console.Write("_");
        }
        Console.Write("\n");
    }
}
