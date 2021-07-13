using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("\\");
                    }
                    else if (j <= i)
                    {
                        Console.Write(" ");
                    }
                }
            }
	    Console.Write("\n");
        }
        else
        {
            Console.Write("\n");
        }
    }
}
