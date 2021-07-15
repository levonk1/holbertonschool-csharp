using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int res = 0;
        foreach (int a in myLList)
        {
            res += a;
        }
        return res;
    }
}
