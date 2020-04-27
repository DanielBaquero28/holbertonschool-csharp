using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myList)
    {
        int sumValue = 0;
        foreach (int val in myList)
        {
            sumValue += val;
        }
        return(sumValue);
    }
}