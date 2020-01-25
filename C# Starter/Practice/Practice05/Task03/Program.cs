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
            Console.WriteLine("Input first non-negative number and one number should be less than another");
            string firstNumber = Console.ReadLine();

            if (int.TryParse(firstNumber, out int convertedFirstNumber) && convertedFirstNumber >= 0)
            {
                Console.WriteLine("Input second non-negative number");
                string secondNumber = Console.ReadLine();

                if (int.TryParse(secondNumber, out int convertedSecondNumber) && convertedSecondNumber >= 0)
                {
                    if (convertedFirstNumber < convertedSecondNumber)
                    {
                        int sum = 0;

                        for (int counter = convertedFirstNumber; counter <= convertedSecondNumber; counter++)
                        {
                            if (counter % 2 == 0)
                                sum += counter;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                        Console.WriteLine("The first variable should be less than second one ");
                }
                else
                    Console.WriteLine("Invalid input");
            }
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
