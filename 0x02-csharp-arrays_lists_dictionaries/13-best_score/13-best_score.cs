using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        List<string> list = new List<string>();
	foreach (KeyValuePair<string, int> kv in myList.OrderBy(kv => kv.Value))
        {
            list.Add(kv.Key);
        }
        return list[list.Count - 1];
    }
}
