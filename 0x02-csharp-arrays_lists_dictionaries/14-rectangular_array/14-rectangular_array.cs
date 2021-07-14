using System;

class Program
{
    static void Main(string[] args)
    {
        int i, j;
        for (i = 0; i < 5; i++)
        {
	    for (j = 0; j < 5; j++)
            {
                if (i == 2 && j == 2)
                    Console.Write("1 ");
                else if (j < 4)
                    Console.Write("0 ");
		else
		    Console.WriteLine("0");
            }
        }
    }
}
