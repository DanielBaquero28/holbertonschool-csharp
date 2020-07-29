<html>
<h1>Project: CSharp Delegates & Events</h1>
<p><strong>In this project we0ll learn about delegates which are heavily used with events. We'll learn what are delegates and how to use them, as well as what are events and how to use them.</strong></p>
<body>
<li><strong>Task 0:</strong> Create a public class called Player with the following:
<ul>
<li>Properties:
<ul>
<li>name: string</li>
<li>maxHp: float</li>
<li>hp: float</li>
<li>You should not be able to change or access the Player’s properties directly from the main file.</li>
</ul>
</li>
<li>Constructor:
<ul>
<li>Prototype: public Player(string name, float maxHp)</li>
<li>Assign parameters to properties accordingly
<ul>
<li>Default name: Player</li>
<li>Default maxHp: 100f</li>
</ul>
</li>
<li>maxHp must be greater than 0, otherwise, set maxHp to the default value of 100f and print maxHp must be greater than 0. maxHp set to 100f by default.</li>
<li>hp should be the same value as maxHp</li>
</ul>
</li>
<li>Method:
<ul>
<li>Prototype: public void PrintHealth()</li>
<li>Format: "name" has "hp" / "maxHp" health.</li>
</ul>
</li>
</ul>
</li>
<li><strong>Task 1:</strong> Based on 0-universal_health, create a delegate CalculateHealth that takes a float amount. Write two methods that follow the prototype of the CalculateHealth delegate:
<ul>
<li>public void TakeDamage(float damage)
<ul>
<li>Prints "name" takes "damage" damage!</li>
<li>If damage is negative, the Player takes 0 damage and prints "name" takes 0 damage!</li>
</ul>
</li>
<li>public void HealDamage(float heal)
<ul>
<li>Prints "name" heals "heal" HP!</li>
<li>If heal is negative, the Player heals 0 HP and prints "name" heals 0 damage!</li>
</ul>
</li>
</ul>
</li>
<li><strong>Task 2:</strong> Based on 1-damage_delegation, inside the TakeDamage() and HealDamage() methods, calculate the new value of the Player’s hp but do not set the value of hp in these methods.
<ul>
<li>If damage is taken, subtract damage from hp</li>
<li>If health is healed, add heal to hp</li>
<p>Create a new method ValidateHP() that sets the new value of the Player’s hp:</p>
<li>Prototype: public void ValidateHP(float newHp)</li>
<li>If newHp is negative, set hp to 0</li>
<li>If newHp is larger than maxHp, set hp to the value of maxHp</li>
<li>Otherwise, set hp to the value of newHp</li>
In the TakeDamage() and HealDamage() methods, add a call to ValidateHP() and pass in the value calculated within that method.
</ul>
</li>
<li><strong>Task 3:</strong> Based on 2-validation, outside of the Player class, create an enum Modifier with the values Weak, Base, Strong.

Outside of the Player class, create a delegate CalculateModifier:
<ul>
<li>Prototype: public delegate float CalculateModifier(float baseValue, Modifier modifier)</li>
<p>Create a method ApplyModifier that follows the prototype of CalculateModifier.</p>
<li>If modifier is Weak, return half of the base value</li>
<li>If modifier is Base, return the base value</li>
<li>If modifier is Strong, return 1.5 times the base value</li>
</ul>
</li>
<li><strong>Task 4:</strong>Based on 3-modified_behavior, outside of the Player class, create a new class CurrentHPArgs that inherits from EventArgs with the following:
<ul>
<li>Properties:
<ul>
<li>currentHp: public float that cannot be modified</li>
</ul>
</li>
<li>Constructor:
<ul>
<li>Takes a float newHp and sets it as currentHp‘s value</li>
</ul>
</li>
Within the Player class, create a new EventHandler of type CurrentHPArgs called HPCheck.

Create a new private property status of type string. In the constructor, set its default value as <name> is ready to go!

Create a new method CheckStatus.
<li>Prototype: private void CheckStatus(object sender, CurrentHPArgs e)</li>
<li>Depending on the value of currentHp, set the Player’s status to the following and print it:
<ul>
<li>If the value is equal to maxHp, print:
<ul>
<li>"name" is in perfect health!</li>
</ul>
</li>
<li>If the value is between ½ of maxHp (inclusive) and maxHp (exclusive), print:
<ul>
<li><name> is doing well!</li>
</ul>
</li>
<li>If the value is between ¼ of maxHp (inclusive) and ½ of maxHp (exclusive), print:
<ul>
<li>"name" isn't doing too great...</li>
</ul>
</li>
<li>If the value is between 0 (exclusive) and ½ of maxHp (exclusive), print:
<ul>
<li>"name" needs help!</li>
</ul>
</li>
<li>If the value is 0, print:
<ul>
<li><name> is knocked out!</li>
</ul>
</li>
</ul>
</li>
</ul>
</li>
Within the Player constructor, assign CheckStatus to the HPCheck EventHandler so that when HPCheck is called, it triggers CheckStatus.

In ValidateHP(), trigger the HPCheck event and pass hp as the CurrentHPArgs value.
<li><strong>Task 5:</strong> Based on 4-check_yourself, create a new method HPValueWarning inside the Player class:
<ul>
<li>Prototype: private void HPValueWarning(object sender, CurrentHPArgs e)</li>
<li>If the value of e‘s currentHp is 0, print Health has reached zero!</li>
<li>Otherwise, print Health is low!</li>
<li>Optionally, change the colors of the console font or background when the warnings are printed:
<img src="https://holbertonintranet.s3.amazonaws.com/uploads/medias/2018/11/ceba84db5ed23fbd2aa5.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIARDDGGGOUWMNL5ANN%2F20200729%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20200729T172044Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=8281471360d6840f22a433ca40b97d446e8cfa4f9cfd03424bcf042483064043">
</li>
</ul>
Create a method called OnCheckStatus() that takes an object of CurrentHPArgs as a parameter and returns nothing. This method should check if e’s currentHp is less than ¼ of maxHp. If it is, assign HPValueWarning to the HPCheck EventHandler.

Within OnCheckStatus(), call HPCheck with the Player object and e.

Replace the call to HPCheck() in ValidateHP() with a call to OnCheckStatus().
</li>
</body>
<br>
<br>
<footer>Made by: <strong><a href=“https://github.com/DanielBaquero28”>Daniel Baquero</a></strong></footer>
</html>