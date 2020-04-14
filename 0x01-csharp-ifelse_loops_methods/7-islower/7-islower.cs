using System;
class Character
{
    public static bool IsLower(char c)
    {
        int asciiVal = (int)Convert.ToChar(c);
        if (asciiVal >= 97 && asciiVal <= 122)
        {
            return(true);
        }
        else
        {
            return(false);
        }
    }
}
