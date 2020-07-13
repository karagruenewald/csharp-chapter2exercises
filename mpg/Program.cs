using System;

namespace mpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string milesInput = Console.ReadLine();
            int miles = int.Parse(milesInput);
            Console.WriteLine("How many gallons of gas have you consumed?");
            string gallonsInput = Console.ReadLine();
            int gallons = int.Parse(gallonsInput);
            int mpg = miles / gallons;
            Console.WriteLine("Your miles per gallon is: " + mpg);
        }
    }
}
