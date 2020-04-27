using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = aQueue.Count;
        Console.WriteLine("Number of items: {0}", count);
        if (count <= 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            string topQueue = aQueue.Peek();
            Console.WriteLine("First item: {0}", topQueue);
        }
        aQueue.Enqueue(newItem);
        if (aQueue.Contains(search))
        {
            Console.WriteLine("Queue contains \"{0}\": True", search);
            while (aQueue.Contains(search))
            {
                aQueue.Dequeue();
            }
        }
        else
        {
            Console.WriteLine("Queue contains \"{0}\": False", search);
        }
        return(aQueue);
    }
}