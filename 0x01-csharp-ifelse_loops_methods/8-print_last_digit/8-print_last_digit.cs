using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int mod = number % 10;
	Console.Write(Math.Abs(mod));
	return Math.Abs(mod);
    }
}
