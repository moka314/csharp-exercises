using System;

namespace InputEx1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            int area;
            string input;

            Console.WriteLine("What is the length?");
            input = Console.ReadLine();
            length = int.Parse(input);
            Console.WriteLine("What is the width?");
            input = Console.ReadLine();
            width = int.Parse(input);
            area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);
            Console.ReadLine();
        }
    }
}
