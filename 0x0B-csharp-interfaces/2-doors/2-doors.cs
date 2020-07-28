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