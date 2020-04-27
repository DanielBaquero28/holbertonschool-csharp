using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i = 0;
        int index = 0;
        if (myLList.Contains(value))
        {
            foreach (int val in myLList)
            {
                if (val == value)
                {
                    index = i;
                }
                else
                {
                    i += 1;
                }
            }
        }
        else
        {
            return(-1);
        }
        return(index);
    }
}
