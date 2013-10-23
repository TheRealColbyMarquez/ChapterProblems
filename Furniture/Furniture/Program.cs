using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the type of wood you would like your furniture to be made out of:");
            Console.WriteLine("Type P for pine");
            Console.WriteLine("Type O for oak");
            Console.WriteLine("Type M for mahogany");
            string choice = Console.ReadLine();

            if (choice == "P")
            {
                Console.WriteLine("Your Pine table will cost $100");
            }

            if (choice == "O")
            {
                Console.WriteLine("Your Oak table will cost $225");
            }

            if (choice == "M")
            {
                Console.WriteLine("Your Mahogany table will cost $310");
            }

            if (choice == "p")
            {
                Console.WriteLine("Your Pine table will cost $100");
            }

            if (choice == "o")
            {
                Console.WriteLine("Your Oak table will cost $225");
            }

            if (choice == "m")
            {
                Console.WriteLine("Your Mahogany table will cost $310");
            }

        }
    }
}
