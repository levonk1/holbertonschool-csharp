using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] numbers = new int[size];

        if (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
		Console.Write("{0}", i);
                if (i < size - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }
        else if (size == 0)
        {
            Console.Write("\n");
        }
	return numbers;
    }
}
