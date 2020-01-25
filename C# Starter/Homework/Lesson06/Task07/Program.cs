using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;

            int counter = 3;
            while (counter != 1)
            {
                factorial = factorial * counter;

                counter--;
            }
            Console.WriteLine(factorial);

            Console.ReadKey();
        }
    }
}
