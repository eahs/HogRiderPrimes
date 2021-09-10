using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 1000; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}