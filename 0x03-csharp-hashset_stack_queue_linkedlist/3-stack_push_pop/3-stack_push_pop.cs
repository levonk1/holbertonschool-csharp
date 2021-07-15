using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search) ? "True" : "False");
        if (aStack.Contains(search))
            while (aStack.Pop() != search);
        aStack.Push(newItem);
        return aStack;
    }
}
