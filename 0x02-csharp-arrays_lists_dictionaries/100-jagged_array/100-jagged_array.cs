using System;

class Program
{
    static void Main(string[] args)
    {
        int [][] jaggedArray = new int[][]
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };
        for (int x = 0; x < jaggedArray.Length; x++)
        {
            for (int y = 0; y < jaggedArray[x].Length; y++)
                if (y < jaggedArray[x].Length - 1)
                    Console.Write("{0} ", jaggedArray[x][y]);
                else
                    Console.Write("{0}\n", jaggedArray[x][y]);
        }
    }
}