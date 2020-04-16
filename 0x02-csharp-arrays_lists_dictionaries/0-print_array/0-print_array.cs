using System;
class Array
{
    public static int[] CreatePrint(int size)
    {
        int i;
        int[] arr = new int[size];

        if (size < 0)
        {
            System.Console.WriteLine("Size cannot be negative");
            return (null);
        }

        if (size == 0)
        {
            System.Console.WriteLine();
            return (arr);
        }

        for (i = 0; i < size; i++)
        {
            if (i < size - 1)
            {
                System.Console.Write("{0} ", i);
            }
            else
            {
                System.Console.WriteLine(i);
            }
            arr[i] = i;
        }
        return (arr);
    }
}