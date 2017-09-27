

namespace HomeWork_Lecture2_Problem_1._Choose_a_Drink
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            var quantiti = double.Parse(Console.ReadLine());
            
            switch (proffesion)
            {
                case "Athlete":
                    Console.WriteLine($"The {proffesion} has to pay {(quantiti* 0.70).ToString("F2")}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The {proffesion} has to pay {(quantiti * 1.00).ToString("F2")}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The {proffesion} has to pay {(quantiti * 1.00).ToString("F2")}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {proffesion} has to pay {(quantiti * 1.70).ToString("F2")}.");
                    break;
                default:
                    Console.WriteLine($"The {proffesion} has to pay {(quantiti * 1.20).ToString("F2")}.");
                    break;
            }
        }
    }
}
