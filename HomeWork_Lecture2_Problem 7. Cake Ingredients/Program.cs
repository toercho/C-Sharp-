

namespace HomeWork_Lecture2_Problem_7._Cake_Ingredients
{
    using System;
   public class StartUp
    {
        public static void Main(string[] args)
        {
            var counter = 0;
           for (var i = 0; i <= 20; i++)
            {
                var ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    i = 20;
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                }else if (i==20)
                {
                    counter++;
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                   
                }else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    counter++;
                }
               
            }
        }
    }
}
