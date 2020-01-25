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
            int counterOne = 0;

            while (counterOne < 10)
            {
                counterOne++;
                Console.WriteLine(counterOne);
            }

            for (int counterTwo = 0; counterTwo < 10; counterTwo++)
            {
                Console.WriteLine(counterTwo);
            }

            int counterThree = 0;
            do
            {
                Console.WriteLine(counterThree);

                counterThree++;
            }
            while (counterThree < 10);

            Console.ReadKey();
        }
    }
}
