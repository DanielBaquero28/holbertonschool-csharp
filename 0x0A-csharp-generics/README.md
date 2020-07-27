<html>
<h1>Project: CSharp Generics</h1>
<p><strong>In this project we'll learn what are generics and what are their purpose.</strong></p>
<body>
<li><strong>Task 0:</strong> Create a new class called Queue<T>.
<ul>
<li>Queue<T> should not inherit from other classes or interfaces.</li>
<li>Within Queue<T>, create a new method CheckType() that returns the Queue’s type.</li>
<li>You are not allowed to use System.Collections or System.Collections.Generic for this project.</li>
</ul>
</li>
<li><strong>Task 1:</strong> Based on 0-queue, within Queue<T>, create a public class called Node with the following properties:
<ul>
<li>value: can be of any type, set its initial value to null</li>
<li>next: must be an object of type Node, set its initial value to null</li>
<li>Define a constructor that takes a value for a new Node as its only parameter and sets it</li>
</ul>
Within Queue<T>, add the following properties:
<ul>
<li>head: must be an object of type Node</li>
<li>tail: must be an object of type Node</li>
<li>count: type int</li>
</ul>
Add a new method Enqueue() to the class Queue that creates a new Node and adds it to the end of the queue.
<ul>
<li>If the queue is empty, the method should make the new node the head of the queue</li>
<li>count should update every time a new node is added</li>
</ul>
Add a new method Count() to the class that returns the number of nodes in the Queue.
</li>
<li><strong>Task 2:</strong> Based on 1-enqueue, add a new method Dequeue() to the class Queue<T> that removes the first node in the queue and returns its value.
<ul>
<li>If the queue is empty, the method should write Queue is empty to the console and return the default value of the parameter’s type</li>
</ul>
</li>
<li><strong>Task 3:</strong> Based on 2-dequeue, add a new method Peek() to the class Queue<T> that returns the value of the first node of the queue without removing the node.
<ul>
<li>If the queue is empty, the method should write Queue is empty to the console and return the default value of the parameter’s type</li>
</ul>
</li>
<li><strong>Task 4:</strong> Based on 3-peek, add a new method Print() to the class Queue<T> that prints the queue, starting from the head.
<ul>
<li>If the queue is empty, the method should write Queue is empty to the console</li>
</ul>
</li>
<li><strong>Task 5:</strong> Based on 4-print, create a method Concatenate() that concatenates all values in the queue only if the queue is of type String or Char.
<ul>
<li>If queue is empty, print Queue is empty and return null</li>
<li>If the queue is not of type String or Char, print Concatenate() is for a queue of Strings or Chars only. to the console and return null</li>
</ul>
</li>
</body>
<br>
<br>
<footer>Made by: <strong><a href=“https://github.com/DanielBaquero28”>Daniel Baquero</a></strong></footer>
</html>