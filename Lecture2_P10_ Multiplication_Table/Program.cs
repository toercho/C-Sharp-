

namespace Lecture2_P10__Multiplication_Table
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
           
            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}
