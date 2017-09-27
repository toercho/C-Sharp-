

namespace Lecture2_P11_Odd_Number
{
    using System;
   public class Program
    {
       public static void Main(string[] args)
        {                                                                                  //bezkrajnost na Programata
            var ri = 100000;                                                               //bezkrajnost na Programata
            for (var i =1; i <= ri; i++)                                                   //bezkrajnost na Programata
            {                                                                              //bezkrajnost na Programata
                var num = int.Parse(Console.ReadLine());                                   //bezkrajnost na Programata
                if (num % 2 == 0)/////                                                     //bezkrajnost na Programata
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine("The number is: " + Math.Abs(num));
                    ri = i;
                }
            }
             
        }
    }
}
