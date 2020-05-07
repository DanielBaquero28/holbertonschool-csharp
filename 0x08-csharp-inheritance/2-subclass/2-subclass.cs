using System;

/// <summary> Object Class </summary>
class Obj
{
    /// <summary> Finds out if derived class inherits exactly by base class </summary>
    /// <returns> true if it is, else false </returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return(true);
        }

        return (false);
    }
}