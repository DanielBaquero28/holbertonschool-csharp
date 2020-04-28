using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        int value = 0;
        foreach (int val in myLList)
        {
            if (n >= val)
            {
                continue;
            }
            else
            {
                value = val;
                break;
            }
        }
        LinkedListNode<int> tmpNode = myLList.Find(value);
        LinkedListNode<int> newNode = myLList.AddBefore(tmpNode, n);
        return(newNode);
    }
}