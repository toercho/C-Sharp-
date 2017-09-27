using System;

namespace HomeWork_Lecture2_Problem_6._Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var seconnd= double.Parse(Console.ReadLine());
            var max = Math.Max(first, seconnd);
            var min = Math.Min(first, seconnd);
            for (var i = min; i<= max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
