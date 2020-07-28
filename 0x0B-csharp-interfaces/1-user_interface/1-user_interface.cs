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

/// <summary> Class that inherits from Base class and all interfaces </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary> Indicates the durability of the object </summary>
    public int durability { get; set; }
    /// <summary> Checks if something was collected or not </summary>
    public bool isCollected { get; set; }

    /// <summary> Takes place when the object interacts with something </summary>
    public void Interact()
    {

    }
    /// <summary> Takes place when the object brakes. </summary>
    public void Break()
    {

    }
    /// <summary> Takes place when the object collects something.</summary>
    public void Collect()
    {

    }
}
