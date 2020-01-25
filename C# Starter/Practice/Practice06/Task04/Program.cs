using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter++)
            {
                for (int counter2 = 0; counter2 < 20; counter2++)
                {
                    for (int counter3 = 0; counter3 < 30; counter3++)
                        Console.WriteLine(counter + counter2 + counter3);
                }
            }

            Console.ReadKey();
        }
    }
}
