using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> divi = new List<int>();
        for (int iter = 0; iter < listLength; iter++)
        {
            try
            {
                divi.Add(list1[iter] / list2[iter]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                divi.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return divi;
    }
}
