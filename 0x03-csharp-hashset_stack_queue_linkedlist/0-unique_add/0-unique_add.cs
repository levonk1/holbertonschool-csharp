using System;
using System.Collections.Generic;
using System.Linq;
class List
{
    public static int Sum(List<int> myList)
    {
        List<int> newList = myList.Distinct().ToList();
        int result = newList.Sum(item => item);
        return result;
    }
}

