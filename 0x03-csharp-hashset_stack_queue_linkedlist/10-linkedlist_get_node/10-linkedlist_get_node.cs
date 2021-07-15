using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int ind = 0;
        foreach (int val in myLList)
        {
            if (ind == n)
                return val;
            ind += 1;
        }
        return (0);
    }
}
