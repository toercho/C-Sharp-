using System;

namespace LAB1Greatings
{
    class Program
    {
        static void Main(string[] args)
        {
           var one= double.Parse(Console.ReadLine());
            var two = double.Parse(Console.ReadLine());
            Console.WriteLine($"{one} + {two} = {one+two}");
        }
    }
}
