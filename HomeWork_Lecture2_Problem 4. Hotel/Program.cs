

namespace HomeWork_Lecture2_Problem_4._Hotel
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            var month = Console.ReadLine();
            double dayStey = double.Parse(Console.ReadLine());
            double studio = 0;
            double doubleP = 0;
            double suite = 0;
            if (month == "May" || month == "October")
            {     
                studio = 50*dayStey;
                doubleP = 65 * dayStey;
                suite = 75 * dayStey;
                if (dayStey > 7)
                {
                    if (dayStey > 7 && month == "October")
                    {
                        dayStey = dayStey - 1;
                    }
                    studio = ((50* dayStey) - (50 * dayStey * 5 / 100));
                }
            }
            if (month == "June" || month == "September")
            {
                studio = 60 * dayStey;
                doubleP = 72 * dayStey;
                suite = 82 * dayStey;
                if (dayStey > 7 && month == "September")
                {
                    studio = 60 * (dayStey - 1);
                }
                if (dayStey > 14)
                {
                   
                    doubleP =  ((72 * dayStey) - (72 * dayStey * 10/ 100));
                }
            }
            if (month == "July" || month == "August" || month == "December")
            {
                studio = 68 * dayStey;
                doubleP = 77 * dayStey;
                suite = 89 * dayStey;
                if (dayStey > 14)
                {       
                    suite = ((89 * dayStey) - (89* dayStey* 15/ 100));
                   
                }  
            }
            Console.WriteLine($"Studio: {studio.ToString("F2")} lv.");
            Console.WriteLine($"Double: {doubleP.ToString("F2")} lv.");
            Console.WriteLine($"Suite: {suite.ToString("F2")} lv.");
        }                                  
    }
}
