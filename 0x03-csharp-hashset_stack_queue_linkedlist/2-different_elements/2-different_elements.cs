using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> unique = new List<int>();

        foreach (int a in list1)
        {
            if (!list2.Contains(a))
                unique.Add(a);
        }

        foreach (int a in list2)
        {
            if (!list1.Contains(a))
                unique.Add(a);
        }

        unique.Sort();
        return unique;
    }
}
