using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
	    return null;
        }

        List<int> num = new List<int>(size);

        if (size == 0)
        {
            Console.Write("\n");
	    return num;
        }

        for (int i = 0; i < size; i++)
        {
            num.Add(i);
	    if(i == size - 1)
            {
                Console.WriteLine(i);
            }
	    else
            {
                Console.Write(i + " ");
            }
        }
	return num;
    }
}
