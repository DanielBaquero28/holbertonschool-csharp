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

    /// <summary> Concatenates all the values of the queue </summary>
    public string Concatenate()
    {
        Node node;
        string new_t = String.Empty;
        if (this.head == null)
        {
            System.Console.WriteLine("Queue is empty");
            return (null);
        }
        if (!(typeof(string) == typeof(T) || typeof(char) == typeof(T)))
        {
            System.Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return (null);
        }

        node = this.head;
        for (int i = 0; i < this.count; i++)
        {
            if (i == 0)
                new_t = node.value.ToString();
            else if (i > 0 && typeof(string) == typeof(T))
                new_t += " " + node.value.ToString();
            else if (i > 0 && typeof(char) == typeof(T))
                new_t += node.value.ToString();
            node = node.next;
        }
        return (new_t);
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
