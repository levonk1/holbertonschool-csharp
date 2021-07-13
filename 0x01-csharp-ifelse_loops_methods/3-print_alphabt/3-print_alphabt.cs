using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char alpha = 'a'; alpha <= 'z'; alpha++)
            {
                if (alpha != 'e' && alpha != 'q')
                {
                    Console.Write(alpha);
                }
            }
        }
    }
}
