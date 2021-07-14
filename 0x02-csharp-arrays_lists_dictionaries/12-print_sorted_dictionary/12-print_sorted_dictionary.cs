using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        foreach (KeyValuePair<string, string> kv in myDict.OrderBy(kv => kv.Key))
        {
            Console.WriteLine("{0}: {1}", kv.Key, kv.Value);
        }
    }
}
