

namespace HomeWork_Lecture2_Problem_1._Choose_a_Drink
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            switch (proffesion)
            {
                case "Athlete" :
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
