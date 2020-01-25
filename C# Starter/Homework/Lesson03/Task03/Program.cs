using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 6;

            // First variant
            bool result = x > y;
            Console.WriteLine("That state that variable x is greater than y is " + result);

            // Second variant
            if (x > y)
                Console.WriteLine("That state the variable x is greater than y is true");
            else
                Console.WriteLine("That state the variable x is greater than y is false");

            Console.ReadKey();
        }
    }
}
