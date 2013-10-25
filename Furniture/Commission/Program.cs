using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            string car;
            double price;
            double commissions = 0;
            Console.WriteLine("Enter the price of the car:");
            car = Console.ReadLine();
            price = Convert.ToDouble(car);

            if (price < 15000)
            {
                commissions = price * 0.05;
                Console.WriteLine("The commissions will be" + commissions.ToString("C"));
            }
            if (price >= 15000 && price <= 24000)
            {
                commissions = price * .07;
                Console.WriteLine("The commissions will be" + commissions.ToString("C"));
            }
            if (price > 24000)
            {
                commissions = price * .10;
                Console.WriteLine("The commissions will be" + commissions.ToString("C"));
            }
        }
    }
}
