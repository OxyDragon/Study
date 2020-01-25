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
            double sum = 0;

            // divider
            int counter = 0;

            Console.WriteLine("Enter first number");
            string firstNumber = Console.ReadLine();

            if (double.TryParse(firstNumber, out double convertedFirstNumber))
            {
                Console.WriteLine("Enter second number");
                string secondNumber = Console.ReadLine();

                if (double.TryParse(secondNumber, out double convertedSecondNumber))
                {
                    Console.WriteLine("Enter third number");
                    string thirdNumber = Console.ReadLine();

                    if (double.TryParse(thirdNumber, out double convertedThirdNumber))
                    {
                        #region Cheking negative values

                        if (convertedFirstNumber < 0)
                        {
                            counter++;
                            sum += convertedFirstNumber;
                        }

                        if (convertedSecondNumber < 0)
                        {
                            counter++;
                            sum += convertedSecondNumber;
                        }

                        if (convertedThirdNumber < 0)
                        {
                            counter++;
                            sum += convertedThirdNumber;
                        }

                        #endregion

                        double average = sum / counter;
                        Console.WriteLine(average);
                    }
                    else
                        Console.WriteLine("Invalid input");
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
