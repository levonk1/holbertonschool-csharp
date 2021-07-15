using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int ind = 0;
        foreach (int a in myLList)
        {
            if (a == value)
                return ind;
            ind += 1;
        }
        return (-1);
    }
}
