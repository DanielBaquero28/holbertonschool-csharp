using System;

/// <summary> Base Class from which other Classes derive from. </summary>
abstract class Base
{
    public string name{ get; set; }

    /// <summary> Overrides ToString() to desired result</summary>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
    
}
