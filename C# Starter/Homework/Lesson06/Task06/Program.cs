using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number from 0 to 100 do you want to skip?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 0 && number <= 100)
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (i == number)
                        continue;

                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
