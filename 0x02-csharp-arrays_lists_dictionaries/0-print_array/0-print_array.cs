using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        var arr = new int[size];
        if (size == 0)
        {
        Console.WriteLine();
            return (arr);
        }

        for(int i = 0; i < size; i++)
        {
            if (i < size - 1)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                Console.Write(i);
            }
            arr[i] = i;
        }
        Console.WriteLine();
        return (arr);
    }
}