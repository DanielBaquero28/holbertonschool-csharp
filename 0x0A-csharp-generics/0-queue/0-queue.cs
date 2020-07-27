using System;

/// <summary> Class Queue of type T </summary>
class Queue<T>
{
    /// <summary> Checks the Type of Queue </summary>
    public Type CheckType()
    {
        return (typeof(T));
    }
}