using System;
 
/// <summary> Shape Base Class </summary>
public class Shape
{
    /// <summary> Area Method, thows an exception </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}