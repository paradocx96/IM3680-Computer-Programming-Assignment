using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;

            Console.WriteLine("Enter User Name :");
            Name = Console.ReadLine();

            switch (Name)
            {
                case "admin":
                    Console.WriteLine("Welcome! Full access granted.");
                    break;
                case "user":
                    Console.WriteLine("Welcome! Limited access granted.");
                    break;
                default:
                    Console.WriteLine("Unknown user.");
                    break;
            }
        }
    }
}