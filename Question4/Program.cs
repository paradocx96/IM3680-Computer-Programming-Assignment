using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            String Number = Console.ReadLine();
            int Num = int.Parse(Number);

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", Num, i, Num * i);
            }
        }
    }
}