using System;
class Number
{
    public static int PrintLastDigit(int number)
    {
        int tmpNumber;

        tmpNumber = number % 10;
        if (tmpNumber < 0)
        {
            tmpNumber = Math.Abs(tmpNumber);
        }
        Console.Write("{0}", tmpNumber);

        return (tmpNumber);
    }
}
