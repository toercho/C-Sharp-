

namespace Lecture2_P8_9._Sum_of_Odd_Numbers
{                                                                                                  
    using System;                                                                                  
    public class StartUp                                                                    
    {                                                                                              
        public static void Main(string[] args)                                                     
        {                                                                                          
            var numberOfOdds = int.Parse(Console.ReadLine());
            var iRuns = 100;
            int iOdd = 0;
            int sum = 0;                                                                           
            for (var i = 1; i <= iRuns; i ++)                                               
            {
                if (i%2!=0)
                {                                                        //Брояч на i=
                    Console.WriteLine(i);                                //Брояч на i=
                    sum = sum + i;                                       //Брояч на i=
                    iOdd += 1;                                           //Брояч на i=
                    if (iOdd == numberOfOdds)                            //Брояч на i=
                    {                                                    //Брояч на i=
                        iRuns = i;                                       //Брояч на i=
                    }                                                    //Брояч на i=
                }                                                                        
                                                                                                  
            }                                                                                      
            Console.WriteLine("Sum: "+sum);                                                        
        }                                                                                           
    }
}
  

//if(num % 2 == 0)
//{
//is even
//else
//{
//is odd
//}