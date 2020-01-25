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
            bool needStop = true;

            int counter = 0;
            while (counter < 10)
            {
                if (counter == 5 && needStop)
                    break;

                Console.WriteLine(counter + 1);

                counter++;
            }

            Console.ReadKey();
        }
    }
}
