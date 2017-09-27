using System;

namespace HomeWork_Lecture_2Problem_9._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {





            var numberInggrediants = int.Parse(Console.ReadLine());
            
            double cheese =0 ;
            double tomato =0 ;                                                        //500
            double salami =0 ;                                                        //150
            double pepper =0 ;                                                        //600
                                                                                     //50 
                                                                                     //

            for (var i=1; i<=numberInggrediants; i++) {
         
              string ingrediant = Console.ReadLine().ToLower();
             
             
              if(ingrediant== "cheese")
              {
                  cheese= cheese+500;
              }else if (ingrediant== "tomato sauce")
              {
                  tomato=tomato+150;
              }
              else if (ingrediant == "salami")
              {
                  salami=salami+600;
              }
              else if (ingrediant == "pepper")
              {
                  pepper=pepper+50;
              }
          }
            double calories = cheese + tomato + salami + pepper;
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
