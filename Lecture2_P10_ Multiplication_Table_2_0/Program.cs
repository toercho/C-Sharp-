

namespace Lecture2_P10__Multiplication_Table
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplayer= int.Parse(Console.ReadLine());
            if (multiplayer > 10)
            {
                Console.WriteLine($"{number} X {multiplayer} = {number * multiplayer}");
            }

            for (var i = multiplayer; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}
