using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number from 0 to 100");
            string number = Console.ReadLine();

            if (double.TryParse(number, out double input))
            {
                for (int counter = 0; counter < Math.Pow(input, 2); counter++)
                {
                    Console.WriteLine("Hello");
                }
            }
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
