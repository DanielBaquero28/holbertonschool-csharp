using System;

/// <summary> Class Queue of type T </summary>
class Queue<T>
{
    /// <summary> Class node (Node Template) </summary>
    public class Node
    {
        public T value;
        public Node next = null;

        /// <summary> Node class constructor </summary>
        public Node(T Value)
        {
            this.value = Value;
        }
    }
    public Node head;
    public Node tail;
    public int count = 0;
    /// <summary> Metod that adds a node to the end of the queue </summary>
    public void Enqueue(T element)
    {
        Node new_node = new Node(element);
        if (this.head == null)
            this.head = new_node;
        else if (this.head == this.tail)
            this.head.next = new_node;
        else
            this.tail.next = new_node;
        this.tail = new_node;
        this.count++;
    }

    /// <summary> Removes first node of the queue </summary>
    public T Dequeue()
    {
        Node tmp_node;
        T num;
        if (this.head == null)
        {
            System.Console.WriteLine("Queue is empty");
            return (default(T));
        }

        tmp_node = this.head.next;
        num = this.head.value;
        this.head = tmp_node;
        count--;

        return (num);

    }

    /// <summary> Returns the value of the head node </summary>
    public T Peek()
    {
        if (this.head == null)
        {
            System.Console.WriteLine("Queue is empty");
            return (default(T));
        }

        return (this.head.value);
    }

    /// <summary> Prints the queue </summary>
    public void Print()
    {
        Node node;
        node = this.head;

        if (this.head == null)
            System.Console.WriteLine("Queue is empty");

        for (int i = 0; i < this.count; i++)
        {
            System.Console.WriteLine(node.value);
            node = node.next;
        }
    }
    /// <summary> Returns the number of nodes in a queue </summary>
    public int Count()
    {
        return (this.count);
    }

    /// <summary> Checks the Type of Queue </summary>
    public Type CheckType()
    {
        return (typeof(T));
    }
}
