using System;

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
    public Decoration(string _name = "Decoration", int _durability = 1, bool _isQuestItem = false)
    {
        if (_durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = _name;
        this.durability = _durability;
        this.isQuestItem = _isQuestItem;
    }

    /// <summary> Prints a message regarding the decoration of the door </summary>
    public void Interact()
    {
        if (this.durability <= 0)
            System.Console.WriteLine("The {0} has been broken.", this.name);
        else if (this.isQuestItem == true)
            System.Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        else
            System.Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
    }

    /// <summary> Handles the Break actions when they take place </summary>
    public void Break()
    {
        this.durability--;
        if (this.durability > 0)
            System.Console.WriteLine("You hit the {0}. It cracks.", this.name);
        if (this.durability == 0)
            System.Console.WriteLine("You smash the {0}. What a mess.", this.name);
        if (this.durability < 0)
            System.Console.WriteLine("The {0} is already broken.", this.name);
    }
}