using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
            return 0;
        int nod = 0;
        nod = myLList.First.Value;
        myLList.RemoveFirst();
        return nod;
    }
}
