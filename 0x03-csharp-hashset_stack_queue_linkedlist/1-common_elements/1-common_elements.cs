using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> list3 = new HashSet<int>(list1);
        List<int> result = new List<int>();
        list3.IntersectWith(list2);

        foreach (int a in list3) 
        {
            result.Add(a);
        }
        
        return result;
    }
}
