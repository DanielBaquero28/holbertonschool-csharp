using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (myList.Count == 0)
        {
            return (null);
        }

        List<bool> evenList = new List<bool>();

        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                evenList.Add(true);
            }
            else
            {
                evenList.Add(false);
            }
        }
        return (evenList);
    
    }
}