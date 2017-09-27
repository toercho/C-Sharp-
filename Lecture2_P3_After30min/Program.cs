using System;

namespace Lecture2_P3_After30min
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = double.Parse(Console.ReadLine());
            var futureMin = min + 30;
            if (futureMin >= 60) {
                hour += 1;
                futureMin = futureMin - 60;
            }
            if (hour > 23) {
                hour = 00;
            }
            if (futureMin < 10)
            {
                Console.WriteLine($"{hour}:0{futureMin}");
            }
            else
            {
                Console.WriteLine($"{hour}:{futureMin}");
            }
            
        }

    }
}
