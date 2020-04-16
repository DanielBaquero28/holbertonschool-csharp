using System;
using System.Collections.Generic;
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

        for (i = 0; i < size; i++)
        {
            arr[i] = i;
            if (i < size - 1)
            {
                System.Console.Write(arr[i] + " ");
            }
            else
            {
                System.Console.WriteLine(arr[i]);
            }
        }

        return (arr);
    }
}