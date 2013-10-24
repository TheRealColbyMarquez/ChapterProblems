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
            Console.WriteLine("Please enter your area code down below to get the rates");
            string area = Console.ReadLine();
            Console.WriteLine("Please enter the amount of time your will be talking for");
            string time = Console.ReadLine();




        }
    }
}
