using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commission
{
    class MonoGram
    {
        public static void Main()
        {
            DisplayMonogram("I", "W", "M");
            DisplayMonogram("Q", "P", "R");
            Console.ReadKey();
        }
        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2}. **", first, middle, last);
        }
    }
}