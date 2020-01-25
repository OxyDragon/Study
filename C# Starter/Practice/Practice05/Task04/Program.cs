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
            int counter = 0;

            Console.WriteLine("input first non-negative number and one number should be less than another");
            string firstNumber = Console.ReadLine();

            if (int.TryParse(firstNumber, out int convertedFirstNumber))
            {
                Console.WriteLine("input second non-negative number");
                string secondNumber = Console.ReadLine();

                if (int.TryParse(secondNumber, out int convertedSecondNumber))
                {
                    if (convertedFirstNumber < convertedSecondNumber)
                    {
                        int secondCounter = 0;

                        for (counter = convertedFirstNumber; counter <= convertedSecondNumber; counter++)
                        {
                            if (counter % 2 == 0)
                            {
                                secondCounter++;

                                if (secondCounter != 2)
                                    Console.WriteLine(counter);
                            }
                        }
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
