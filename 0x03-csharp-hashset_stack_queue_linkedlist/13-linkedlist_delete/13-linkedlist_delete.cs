using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int num = 0;
        LinkedListNode<int> actual = myLList.First;
        for (; num <= index && actual.Next != null; num++)
        {
            if (num == index)
                myLList.Remove(actual);
            actual = actual.Next;
        }
        if (num == index)
            myLList.Remove(actual);
    }
}
