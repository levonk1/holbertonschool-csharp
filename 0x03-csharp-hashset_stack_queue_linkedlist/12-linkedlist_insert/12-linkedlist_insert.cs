using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newn = new LinkedListNode<int>(n);
        if (myLList.First == null || myLList.First.Value >= newn.Value)
        {
            myLList.AddFirst(n);
            return newn;
        }
        LinkedListNode<int> actual = myLList.First;
        while (actual.Next != null && actual.Next.Value < newn.Value)
            actual = actual.Next;
        myLList.AddAfter(actual, newn);
        return newn;
    }
}
