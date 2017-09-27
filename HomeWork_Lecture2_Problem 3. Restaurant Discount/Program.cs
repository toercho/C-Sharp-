using System;

namespace HomeWork_Lecture2_Problem_3._Restaurant_Discount
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            double discount = 0;
            double packPrise = 0;
            double allPrice = 0;
            double finalPrice = 0;

            string hall = "";
            if (package== "Normal")
            {
                discount = 5;
                packPrise = 500;
            }else if (package== "Gold")
            {
                discount = 10;
                packPrise = 750;
            }
            else if (package == "Platinum")
            {
                discount = 15;
                packPrise = 1000;
            }
            if (capacity <= 50)
            {
                hall ="Small Hall";
                Console.WriteLine("We can offer you the "+hall);
                allPrice = (2500 + packPrise);
                finalPrice = (allPrice - ((allPrice* discount) /100)) / capacity;
                Console.WriteLine($"The price per person is {finalPrice.ToString("F2")}$");

            }
            else if (capacity <= 100)
            {
                hall = "Terrace";
                Console.WriteLine("We can offer you the " + hall);
                allPrice = (5000 + packPrise);
                finalPrice =( allPrice - ((allPrice * discount) / 100)) / capacity;
                Console.WriteLine($"The price per person is {finalPrice.ToString("F2")}$");
            }
            else if (capacity <= 120)
            {
                hall = "Great Hall";
                Console.WriteLine("We can offer you the " + hall);
                allPrice = (7500 + packPrise) ;
                finalPrice = (allPrice - ((allPrice * discount) / 100)) / capacity;//1275
                Console.WriteLine($"The price per person is {finalPrice.ToString("F2")}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
