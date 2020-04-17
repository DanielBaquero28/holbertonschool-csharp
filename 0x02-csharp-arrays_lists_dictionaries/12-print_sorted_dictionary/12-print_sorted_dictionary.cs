using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> sortedDict = new SortedList<string, string>(myDict);
        foreach (KeyValuePair<string, string> item in sortedDict)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }
    }
}