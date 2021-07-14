using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.Write("\n");
            return;
        }

        int len = array.Length - 1;
        for (; len >= 0 ; len--)
        {
            if (len == 0)
                Console.WriteLine("{0}", array[len]);
	    else
                Console.Write("{0} ", array[len]);
        }
    }
}
