using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int iter = 0;
        try
        {
            while (iter < n)
            {
                Console.WriteLine(myList[iter]);
                iter ++;
            }
        }
        catch { }
        return (iter);
    }
}
