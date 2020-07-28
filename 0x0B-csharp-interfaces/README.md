<html>
<h1>Project: CSharp Interfaces</h1>
<p><strong>In this project we'll learn what are interfaces and how they are used.</strong></p>
<body>
<li><strong>Task 0:</strong> Create an abstract class called Base containing the following:
<ul>
<li>public property name
<ul>
<li>name should be a string</li>
</ul>
</li>
<li>override ToString() method to return the following:
<ul>
<li><name> is a <type> (ex. Garden Gate is a Door)</li>
</ul>
</li>
</ul>
</li>
<li><strong>Task 1:</strong> Based on 0-abstract_thinking, create an interface called IInteractive.
<li>method void Interact()</li>
Create an interface called IBreakable
<li>property durability
<li>durability should be an int</li>
</li>
<li>method void Break()</li>
Create an interface called ICollectable.
<li>property isCollected
<li>isCollected should be a bool</li>
</li>
<li>method void Collect()</li>
You do not need to fully implement the methods for this task.
<br>
Create a new class called TestObject that inherits from Base and all three interfaces.
</li>
<li><strong>Task 2:</strong> Based on 1-user_interface, delete the TestObject class. Create a new class called Door that inherits from Base and IInteractive.
<ul>
<li>define constructor that sets the value of name
<li>if name isn’t provided, the default value should be Door</li>
</li>
<li>implement Interact() so that it prints:
<li>You try to open the "name". It's locked.</li>
</li>
</ul>
</li>
<li><strong>Task 3:</strong> Based on 2-doors, create a new class called Decoration that inherits from Base, IInteractive, and IBreakable.
<ul>
<li>add public bool isQuestItem</li>
<li>define constructor that sets the value of name, durability, and isQuestItem
<ul>
<li>if name isn’t provided, the default value should be Decoration</li>
<li>if durability isn’t provided, the default value should be 1</li>
<li>if durability is 0 or less, throw an exception that states Durability must be greater than 0</li>
<li>if isQuestItem isn’t provided, the default value should be false</li>
</ul>
</li>
<li>implement Interact()
<ul>
<li>if the durability is 0 or less, print:
<li>The "name" has been broken.</li>
</li>
<li>otherwise, if isQuestItem is true, print:
<li>You look at the "name". There's a key inside.</li>
</li>
<li>if isQuestItem is false, write:
<li>You look at the "name". Not much to see here.</li>
</li>
</ul>
</li>
<li>implement Break() so that it decrements durability by 1
<ul>
<li>if durability is greater than 0, print:
<li>You hit the "name". It cracks.</li>
</li>
<li>if durability is 0, print:
<li>You smash the <name>. What a mess.</li>
</li>
<li>if durability is less than 0, print:
<li>The "name" is already broken.</li>
</li>
</ul>
</li>
</ul>
</li>
<li><strong>Task 4:</strong> Based on 3-decorations, create a new class called Key that inherits from Base and ICollectable.
<ul>
<li>define constructor that sets the value of name and isCollected
<li>if name isn’t provided, the default value should be Key</li>
<li>if isCollected isn’t provided, the default value should be false</li>
</li>
<li>implement Collect()
<li>if isCollected is false, set it to true and print:
<li>You pick up the "name".</li>
</li>
<li>if isCollected is true, print:
<li>You have already picked up the "name".</li>
</li>
</li>
</ul>
</li>
<li><strong>Task 5:</strong> Based on 4-keys, create a new class called RoomObjects and a method called IterateAction. This method should take a list of all objects, iterate through it, and execute methods depending on what interface that item implements. (ex: if the item uses IInteractive, your IterateAction method should call Interact() on it)
<ul>
<li>Class: RoomObjects</li>
<li>Prototype: public static void IterateAction(List(Base) roomObjects, Type type)</li>
</ul>
</li>
<li><strong>Task 6:</strong> Based on 5-iterate_act, remove the RoomObjects class created in the previous task. Create a new generic class Objs<T> that creates a collection of type T objects that can be iterated through using foreach.
<ul>
<li>Class: Objs<T></li>
<li>Objs(T) must inherit from and implement IEnumerable(T)</li>
</ul>
</li>
</body>
<br>
<br>
<footer>Made by: <strong><a href=“https://github.com/DanielBaquero28”>Daniel Baquero</a></strong></footer>
</html>