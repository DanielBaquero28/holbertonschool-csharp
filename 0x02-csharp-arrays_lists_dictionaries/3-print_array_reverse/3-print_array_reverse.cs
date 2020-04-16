using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
        }
        else
        {
            int len = array.Length;
            int[] revArr = new int[len];
            for (int i = 0, j = len - 1; i < len; i++, j--)
            {
                revArr[i] = array[j];
                if (i < len - 1)
                {
                    Console.Write("{0} ", revArr[i]);
                }
                else
                {
                    Console.WriteLine("{0}", revArr[i]);
                }
            }
        }
    }
}