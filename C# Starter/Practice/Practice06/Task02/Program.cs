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
            Console.WriteLine(" select the way in which you want to write the numbers from 0 to 10, " +
                "if you want for loop - write true, if you want while loop - write false ");
            string input = Console.ReadLine();

            if (bool.TryParse(input, out bool result))
            {
                if (result)
                {
                    for (int counter = 0; counter < 10; counter++)
                        Console.WriteLine(counter);
                }
                else
                {
                    int counter = 0;

                    while (counter < 10)
                    {
                        Console.WriteLine(counter + 1);

                        counter++;
                    }
                }
            }
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
