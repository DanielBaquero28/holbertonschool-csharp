using System;
using System.Collections.Generic;
class List
{
    public static int Sum(List<int> myList)
    {
        int sumVal = 0;
        var mySet = new HashSet<int>(myList);
        foreach (int element in mySet)
        {
            sumVal += element;
        }
        return(sumVal);

    }
}