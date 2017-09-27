using System;

namespace HomeWork_Lecture_2_Problem_9._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            bool work = true;
            var counter = 0;

            try
            {
                do
                {
                    var x = int.Parse(Console.ReadLine());
                    counter++;
                }
                while (work = true);
                
            }
            catch (Exception)
            {
                work = false;
                Console.WriteLine($"{counter}");

            }
            
        }
    }
}
