using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int counter = 0;

                while (counter < i)
                {
                    Console.WriteLine(i);

                    counter++;
                }
            }

            Console.ReadKey();
        }
    }
}
