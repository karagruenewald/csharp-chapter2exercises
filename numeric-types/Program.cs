using System;

namespace numeric_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string userLength = Console.ReadLine();
            int length = int.Parse(userLength);
            Console.WriteLine("What is the width of the rectangle?");
            string userWidth = Console.ReadLine();
            int width = int.Parse(userWidth);
            Console.WriteLine("The area of the rectangle is " + (length * width));
        }
    }
}
