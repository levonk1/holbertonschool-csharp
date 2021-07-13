using System;

class Line
{
    public static void PrintLine(int length)
    {
	if (length > 0)
        {
           string line =  new String('_', length);
	   Console.WriteLine(line);
        }
        else
        {
            Console.Write("\n");
        }
    }
}
