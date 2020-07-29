using System;
using System.Collections;
using System.Collections.Generic;

/// <summary> Base Class from which other Classes derive from. </summary>
public abstract class Base
{
    /// <summary> Name Variable </summary>
    public string name;

    /// <summary> Overrides ToString() to desired result</summary>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
}

/// <summary> Interactive interface </summary>
interface IInteractive
{
    void Interact();
}

/// <summary> Breakable Interface </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary> Collectable Interface </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary> Door class which handles Door actions </summary>
public class Door : Base, IInteractive
{
    /// <summary> Door Constructor </summary>
    public Door(string _name = "Door")
    {
        this.name = _name;
    }

    /// <summary> Prints a message when the door interacts with something </summary>
    public void Interact()
    {
         System.Console.WriteLine("You try to open the " + this.name + ". It's locked.");
    }
}

/// <summary> Handles operations for Decoration </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> Durability Property</summary>
    public int durability { get; set; }
    /// <summary> In charge of knowing if it has a QuestItem </summary>
    public bool isQuestItem = false;

    /// <summary> Decoration Constructor </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary> Prints a message regarding the decoration of the door </summary>
    public void Interact()
    {
        if (this.durability <= 0) System.Console.WriteLine("The {0} has been broken.", this.name);
        else if (this.isQuestItem == true) System.Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        else System.Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
    }

    /// <summary> Handles the Break actions when they take place </summary>
    public void Break()
    {
        this.durability--;
        if (this.durability > 0) System.Console.WriteLine("You hit the {0}. It cracks.", this.name);
        if (this.durability == 0) System.Console.WriteLine("You smash the {0}. What a mess.", this.name);
        if (this.durability < 0) System.Console.WriteLine("The {0} is already broken.", this.name);
    }
}

/// <summary> Key Class handles the key actions when it interacts with door </summary>
public class Key : Base, ICollectable
{
    /// <summary> Property that handles if the key was collected or not </summary>
    public bool isCollected { get; set; }
    /// <summary> Key Constructor </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    
    /// <summary> Handles action regarding key collection </summary>
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            System.Console.WriteLine("You pick up the {0}.", this.name);
        }
        else
            System.Console.WriteLine("You have already picked up the {0}.", this.name);
    }
}

/// <summary> Handles the Objects in the Room </summary>
public class RoomObjects
{
    /// <summary> Recieves a list of objects and executes methods depending
    /// on the type of interface it recieves as a parameter
    /// </summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base obj in roomObjects)
        {
            if (type.IsInstanceOfType(obj))
            {
                if (type == typeof(IInteractive))
                    ((IInteractive)obj).Interact();
                else if (type == typeof(IBreakable))
                    ((IBreakable)obj).Break();
                else if (type == typeof(ICollectable))
                    ((ICollectable)obj).Collect();
            }
        }
    }
}