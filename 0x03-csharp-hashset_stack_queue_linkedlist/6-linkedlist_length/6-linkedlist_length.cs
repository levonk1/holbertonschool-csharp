using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int num = 0;
        foreach (int n in myLList)
             num += 1;
        return (num);
    }
}
