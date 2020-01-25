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
            int counter = 3;

            do
            {
                Console.WriteLine("Some operation");

                counter++;
            }
            while (counter < 3);

            Console.ReadKey();
        }
    }
}
