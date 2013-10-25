using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    Available zip codes:      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|Area Code | Per-Minute Rate($)|");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|   262    |    0.07           |");
            Console.WriteLine("|   414    |    0.10           |");
            Console.WriteLine("|   608    |    0.05           |");
            Console.WriteLine("|   715    |    0.16           |");
            Console.WriteLine("|   815    |    0.24           |");
            Console.WriteLine("|   920    |    0.14           |");
            Console.WriteLine("--------------------------------");

            int[] areacode = new int[6] { 262, 414, 608, 715, 815, 920 };
            Double[] rate = new double[6] { .07, .10, .05, .16, .24, .14 };
            double cost = 0;
            string entry;
            string minutes;

            Console.WriteLine("Please type in your area code");
            entry = Console.ReadLine();
            Console.WriteLine("Please enter the number of minutes you will use");
            minutes = Console.ReadLine();

            for (int i = 0; i < areacode.Length; i++)
            {
                if (entry == areacode[i].ToString())
                {
                    cost = rate[i] * Convert.ToInt32(minutes);
                    Console.WriteLine("The price will be" + cost.ToString("C"));
                    break;
                }
                else if (i == areacode.Length - 1)
                {
                    Console.WriteLine("Please enter a valid zip code");
                }


            }
        }
    }
}
