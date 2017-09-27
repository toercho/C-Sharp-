using System;

namespace HomeWork_Lecture2_Problem_5._Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {


            var z = 1;
            Console.WriteLine("This is program for Word in Plural in English");
            for (var i = 0; i <= z; i++)
            {
                Console.WriteLine("Please enter word");
                z++;
                string str = Console.ReadLine();
                if (str == "Stop")
                {
                    break;
                }

                char wordY = str[str.Length - 1];
                char wordYS = str[str.Length - 2];
                if (wordY == 'y')
                {
                    var rqzana = str.Remove(str.Length - 1);
                    Console.WriteLine(rqzana + "ies");
                }
                else if (wordYS == 'c' && wordY == 'h' || wordYS == 's' && wordY == 'h' || wordY == 'o' || wordY == 's' || wordY == 'x' || wordY == 'z')
                {
                    Console.WriteLine(str + "es");
                }
                else
                {
                    Console.WriteLine(str + "s");
                }
            }

        }
    }
}







a b cd e fg h ij k  lm  n op q  r st u vw  x y  z
