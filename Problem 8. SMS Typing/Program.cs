

namespace Problem_8._SMS_Typing
{
   using System;
   public class StartUp
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());//thats number of rows  char wordY = str[str.Length - 1];
            var  str ="";
            for (var i = 1; i <= a; i++)
            {
                string b =Console.ReadLine();

                for (var z=0; z<=b.Length-1; z++)
                {
                    str = str + b[z] ;
                    Console.WriteLine(str);

                }
                str = str + " ";
            }


        }
    }
}
