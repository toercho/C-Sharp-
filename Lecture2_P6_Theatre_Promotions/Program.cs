

namespace Lecture2_P6_Theatre_Promotions
{
   using System;

    public class StartUp
    {
       public static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else if (age <= 18)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("12$");
                }else if (day == "Weekend")
                {
                    Console.WriteLine("15$");
                }else if(day=="Holiday")
                {
                    Console.WriteLine("5$");
                }
            }
            else if (age <= 64)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                else if (day == "Holiday")
                {
                    Console.WriteLine("12$");
                }
            }
            else if (age <= 122)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (day == "Holiday")
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}
