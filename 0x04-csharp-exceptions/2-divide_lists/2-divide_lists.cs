using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        var newList = new List<int>();
        int divideVal = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                divideVal = list1[i] / list2[i];
                newList.Add(divideVal);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                newList.Add(0);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return(newList);
    }
}