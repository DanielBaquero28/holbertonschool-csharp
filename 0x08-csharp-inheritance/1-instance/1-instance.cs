using System;


/// <summary> Object Class </summary>
class Obj
{
    /// <summary> Finds out if an object is an instance of Array or inherited from a class Array </summary>
    /// <returns> true if it is, else false </returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
        {
            return (true);
        }

        return (false);
    }
}