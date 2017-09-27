using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;
            Console.WriteLine($"{area.ToString("F2")}");
        }
    }
}
