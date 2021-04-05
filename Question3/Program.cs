using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1)
            for (int i = 1; i < 8; i++)
            {
                Console.Write("{0},", i);
            }
            Console.WriteLine();
            
            //(2)
            for (int i = 3; i < 24;)
            {
                Console.Write("{0},",i);
                i = i + 5;
            }
            Console.WriteLine();
            
            //(3)
            for (int i = 20; i > -11;)
            {
                Console.Write("{0},", i);
                i = i - 6;
            }
        }
    }
}