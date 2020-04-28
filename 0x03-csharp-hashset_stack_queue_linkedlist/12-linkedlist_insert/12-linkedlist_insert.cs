using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> tmpNode = myLList.First;
        while (tmpNode != null)
        {
            if (n >= tmpNode.Value)
            {
                tmpNode = tmpNode.Next;
            }
            else
            {
                LinkedListNode<int> newNode = myLList.AddBefore(tmpNode, n);
                return(newNode);
            }
        }
        return(myLList.AddLast(n));
    }
}