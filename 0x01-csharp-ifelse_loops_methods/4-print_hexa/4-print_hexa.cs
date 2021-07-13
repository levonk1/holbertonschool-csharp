using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 98; n++)
            {
                Console.Write("{0:D} = 0x{0:x}\n", n);
            }
        }
    }
}
