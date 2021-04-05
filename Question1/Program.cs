using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the Roll Number of the student :");
            String rollNum = Console.ReadLine();

            Console.WriteLine("Input the Name of the Student :");
            String Name = Console.ReadLine();

            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application :");
            String Marks = Console.ReadLine();
            String[] Mark = Marks.Split(' ');
            int[] Num = Array.ConvertAll(Mark, int.Parse);

            int Total = Num[0] + Num[1] + Num[2];
            decimal Percentage = Math.Round(((Total * 100m) / 300m), 2);

            Console.WriteLine("Roll No : {0}", rollNum);
            Console.WriteLine("Name of Student: {0}", Name);
            Console.WriteLine("Marks in Physics: {0}", Num[0]);
            Console.WriteLine("Marks in Chemistry: {0}", Num[1]);
            Console.WriteLine("Marks in Computer Application : {0}", Num[2]);
            Console.WriteLine("Total Marks = {0}", Total);
            Console.WriteLine("Percentage = {0}", Percentage);
            Console.WriteLine("Division = First");
        }
    }
}