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
/// <summary> Derived Class Rectangle inherits from Shape Class </summary>
public class Rectangle: Shape
{
    /// <summary> Width field </summary>
    private int width;
    /// <summary> Height field </summary>
    private int height;

    /// <summary> Property Width that gets and sets field width </summary>
    public int Width
    {
        get
        {
            return (this.width);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                this.width = value;
            }
        }
    }

    /// <summary> Property Height that gets and sets field height </summary>
    public int Height
    {
        get
        {
            return (this.height);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                this.height = value;
            }
        }
    }

    /// <summary> Overrides Area() </summary>
    public new int Area()
    {
        return (this.width * this.height);
    }

    /// <summary> Overrides ToString() to print a custom text </summary>
    public override string ToString()
    {
        return ("[Rectangle] " + this.width + " / " + this.height);
    }
}