using System;

namespace GameCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHelth = int.Parse(Console.ReadLine());
            var maxH= int.Parse(Console.ReadLine());
            var currentEnergy= int.Parse(Console.ReadLine());
            var maxEnergy= int.Parse(Console.ReadLine());
            var difHelt = maxH - currentHelth;                                       //REPEAT NEW STRING !!!!!
            var difEn = maxEnergy - currentEnergy;                                   //REPEAT NEW STRING !!!!!
            string dotHelth = new string('.',difHelt) ;                              //REPEAT NEW STRING !!!!!
            string slashHelt = new string('|', currentHelth);                        //REPEAT NEW STRING !!!!!
            string dotEnergy = new string('.', difEn);                               //REPEAT NEW STRING !!!!!
            string slashEnergy = new string('|', currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{slashHelt}{dotHelth}|");
            Console.WriteLine($"Energy: |{slashEnergy}{dotEnergy}|");
        }
    }
}
