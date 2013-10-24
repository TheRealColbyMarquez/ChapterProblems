using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZipCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string entry;
            int[] zip = new int[10] { 18040, 18041, 18042, 18043, 18044, 18045, 18046, 18047, 18048, 18049 };

            for (int i = 0; i < zip.Length; i++)
            {
                Console.WriteLine(zip[i]);
            }
            while (counter < zip.Length)
            {
                Console.WriteLine(zip[counter]);
                counter++;
            }
            Console.WriteLine("Enter your zipcode");
            entry = Console.ReadLine();

            if(entry != "18040" && entry != "18041"  && entry != "18042" && entry != "18043" && entry != "18044" && entry != "18045" && entry != "18046" && entry != "18047" && entry != "18048" && entry != "18049")
            {
                Console.WriteLine("Sorry, we do not deliver to your location");
            }
            else
            {
                Console.WriteLine("We can deliver to your location");
            }
            }
        }
    }
