using System;

namespace lecture2_P4_Mont_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = int.Parse(Console.ReadLine());
            if (month > 12)
            {
                Console.WriteLine("Error!");
            }else
            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;                                    //DEFAUT e важно!!!!!
                    default:                                      //DEFAUT e важно!!!!!
                         Console.WriteLine("Error!");             //DEFAUT e важно!!!!!
                         break;                                   //DEFAUT e важно!!!!!
                }                                                 //DEFAUT e важно!!!!!
            }
            
        }
    }
}
