using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = aStack.Count;
        Console.WriteLine("Number of items: {0}", count);
        if (count <= 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            string topStack = aStack.Peek();
            Console.WriteLine("Top Item: {0}", topStack);
        }
        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            while(aStack.Contains(search))
            {
                aStack.Pop();
            }
        }
        else
        {
            Console.WriteLine("Stack contains \"{0}\": False", search);
        }
        aStack.Push(newItem);
        return(aStack);
    }
}
