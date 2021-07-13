using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        System.Console.WriteLine($"{str}{str}{str}");
        System.Console.WriteLine(str.Substring(0, 9));
    }
}