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

        for (i = 0; i < size - 1; i++)
        {
            System.Console.Write("{0} ", i);
        }
        System.Console.WriteLine("{0}", i);
        return (arr);
    }
}