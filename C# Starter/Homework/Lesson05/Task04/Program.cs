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
            Console.WriteLine("Please, enter 1 number");
            string firstNumber = Console.ReadLine();

            if (int.TryParse(firstNumber, out int convertedFirstNumber))
            {
                Console.WriteLine("Please, enter 2 number");
                string secondNumber = Console.ReadLine();

                if (int.TryParse(secondNumber, out int convertedSecondNumber))
                {
                    if (convertedFirstNumber > convertedSecondNumber || convertedFirstNumber != 0 || convertedSecondNumber != 0)
                        Console.WriteLine("Corrent");
                    else
                        Console.WriteLine("False");
                }
            }

            Console.ReadKey();
        }
    }
}
