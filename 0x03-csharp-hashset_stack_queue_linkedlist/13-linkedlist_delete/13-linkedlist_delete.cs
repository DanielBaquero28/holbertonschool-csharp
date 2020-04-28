using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index >= myLList.Count)
        {
            return;
        }
        LinkedListNode<int> tmpNode = myLList.First;
        int i = 0;
        while (tmpNode != null)
        {
            if (i == index)
            {
                myLList.Remove(tmpNode);
                return;
            }
            else
            {
                tmpNode = tmpNode.Next;
                i += 1;
            }
        }
    }
}