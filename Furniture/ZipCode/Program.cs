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
            int[] zip = new int[10];
            zip[0] = 18040;
            zip[1] = 18041;
            zip[2] = 18042;
            zip[3] = 18043;
            zip[4] = 18044;
            zip[5] = 18045;
            zip[6] = 18046;
            zip[7] = 18047;
            zip[8] = 18048;
            zip[9] = 18049;

            Console.WriteLine("Please enter your zip code:");
            string entry = Console.ReadLine();
            for (int i = 0; i < zip.Count(); i++)
            {
                if (entry == zip[i].ToString())
                {
                    Console.WriteLine("The delivery company will deliver to you");
                    break;
                }
                else
                {
                    Console.WriteLine("The delivery company cannot deliver to you");
                    break;
                }
            }
        }
    }
}
