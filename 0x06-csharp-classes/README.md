<html>
<h1>Project: CSharp Classes</h1>
<p><strong>In this project we'll start reviewing the three pillars of OOP: Encapsulation, Inheritance and Polymorphism</strong></p>
<body>
<li><strong>Task 0:</strong> Create a new namespace Enemies. Create an empty public class Zombie within Enemies that defines a zombie.</li>
<li><strong>Task 1:</strong> Based on 0-enemy, write a public class Zombie that defines a zombie by:
<ul>
<li>public field health</li>
<li>health should be an int and have no value</li>
<li>public constructor: public Zombie()
<ul>
<li>sets the value of health to 0</li>
</ul>
</li>
</ul>
</li>
<li><strong>Task 2:</strong> Based on 1-enemy, write a public class Zombie that defines a zombie by:
<ul>
<li>public field health</li>
<li>health should be an int and have no value</li>
<li>public constructor: public Zombie()
<ul>
<li>sets the value of health to 0</li>
</ul>
</li>
<li>a new public constructor: public Zombie(int value)
<ul>
<li>value must be greater than or equal to 0</li>
<li>if value is less than 0, throw an ArgumentException with the message Health must be greater than or equal to 0</li>
</ul>
</li>
</ul>
</li>
<li><strong>Task 3:</strong> Based on 2-enemy, write a public class Zombie that defines a zombie by:
<ul>
<li>private field health</li>
<li>health should be an int and have no value</li>
<li>public constructor: public Zombie()
<ul>
<li>sets the value of health to 0</li>
</ul>
</li>
<li>public constructor: public Zombie(int value)
<ul>
<li>value must be greater than or equal to 0</li>
</ul>
</li>
<li>public method public int GetHealth() that returns the value of health of the Zombie object</li>
</ul>
</li>
<li><strong>Task 4:</strong> Based on 3-enemy, write a public class Zombie that defines a zombie by:
<ul>
<li>private field health</li>
<li>health should be an int and have no value</li>
<li>public constructor: public Zombie()
<ul>
<li>sets the value of health to 0</li>
</ul>
</li>
<li>public constructor: public Zombie(int value)
<ul>
<li>value must be greater than or equal to 0</li>
</ul>
</li>
<li>private field name</li>
<li>name should be a string and have a default value of (No name)</li>
<li>public property Name
<ul>
<li>get: retrieve name</li>
<li>set: set name</li>
</ul>
</li>
<li>public method public int GetHealth() that returns the value of health of the Zombie object</li>
</ul>
</li>
<li><strong>Task 5:</strong> Based on 4-enemy, write a public class Zombie that defines a zombie by:
<ul>
<li>private field health</li>
<li>health should be an int and have no value</li>
<li>public constructor: public Zombie()
<ul>
<li>sets the value of health to 0</li>
</ul>
</li>
<li>public constructor: public Zombie(int value)
<ul>
<li>value must be greater than or equal to 0</li>
</ul>
</li>
<li>private field name</li>
<li>name should be a string and have a default value of (No name)</li>
<li>public property Name
<ul>
<li>get: retrieve name</li>
<li>set: set name</li>
</ul>
</li>
<li>public method public int GetHealth() that returns the value of health of the Zombie object</li>
<li>public .toString() override that prints the Zombie object’s attributes to stdout
<ul>
<li>Format: Zombie name: <name> / Total Health: <health> (see example below)</li>
</ul>
</li>
</ul>
</li>
</body>
<br>
<br>
<footer>Made by: <strong><a href=“https://github.com/DanielBaquero28”>Daniel Baquero</a></strong></footer>
</html>