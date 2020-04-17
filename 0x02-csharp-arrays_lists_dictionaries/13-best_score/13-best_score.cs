using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int maxVal = 0;
        string key = "";

        if (myList.Count == 0)
        {
            return ("None");
        }

        foreach(KeyValuePair<string, int> item in myList)
        {
            if (item.Value >= maxVal)
            {
                maxVal = item.Value;
                key = item.Key;
            }
            else
            {
                continue;
            }
        }
        return (key);

    }
}