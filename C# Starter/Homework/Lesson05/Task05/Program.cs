using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 6, c = 7, d = 4;

            if (a > b ^ c < d)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
