

namespace HomeWork_Lecture_2_Problem_11._5_Different_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = b - a;
            if (c < 5)
            {
                Console.WriteLine("No");
            }else
            {
                for (var i = a; i <=b; i++)
                {  
                    for(var x = a; x <= b; x++)
                    {
                        for(var z=a; z<=b; z++)
                        {
                            for(var q = a; q <= b; q++)
                            {
                                for(var w = a; w <= b; w++)
                                {
                                    if (x <= i || z <= x || q <= z || w <= q) continue;
                                    else
                                    {
                                        Console.WriteLine($"{i} {x} {z} {q} {w}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
