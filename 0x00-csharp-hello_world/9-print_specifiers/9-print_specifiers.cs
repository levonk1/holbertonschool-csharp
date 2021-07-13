using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        Console.WriteLine($"Percent: {percent.ToString("0.00%")}");
        Console.WriteLine($"Currency: {currency.ToString("C2", new CultureInfo("en-US.utf-8"))}");
    }
}