

namespace HomeWork_Lecture_2_Problem_12._Test_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
          
          var a = int.Parse(Console.ReadLine());
          var b = int.Parse(Console.ReadLine());
          var sum = int.Parse(Console.ReadLine());
          var firsr= 0;
          var second = 0;
          var counter = 0;

          for (int i = a; i >= 1; i--)
          {
              for (int j = 1; j <= b; j++)
              {
                 if (firsr >= sum)
                 {
                  break;
                 }
                  second = 3 * j * i;
                  firsr = second + firsr;
                  counter++;
              }
            }
            Console.WriteLine($"{counter} combinations");
            if (firsr >= sum)
            {
                Console.WriteLine($"Sum: {firsr} >= {sum}");
            }else
            {
                Console.WriteLine($"Sum: {firsr}");
            }
            
        }
    }
}
