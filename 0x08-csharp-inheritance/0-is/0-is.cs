using System;

/// <summary> Object Class </summary>
class Obj
{
    /// <summary> Finds out if obj is of type int </summary>
    /// <returns> true if it is, else false </returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
        {
            return (true);
        }

        return (false);
    }
}

