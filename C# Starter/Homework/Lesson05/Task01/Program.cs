using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3, c = 4, d = 5;

            if (a > b && c < d)
                Console.WriteLine("Correct!");
            else
                Console.WriteLine("False!");

            Console.ReadKey();
        }
    }
}
