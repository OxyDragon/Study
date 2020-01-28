using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        #region Calculator

        static double Sum(double operandOne, double operandTwo)
        {
            double sum = operandOne + operandTwo;

            return sum;
        }

        static double Difference(double operandOne, double operandTwo)
        {
            double difference = operandOne - operandTwo;

            return difference;
        }

        static double Multiply(double operandOne, double operandTwo)
        {
            double multiply = operandOne * operandTwo;

            return multiply;
        }

        static double Divide(double operandOne, double operandTwo)
        {
            double division = default;
            if (operandTwo != 0)
                division = operandOne / operandTwo;

            return division;
        }

        static double Calculator(double operandOne, double operandTwo, char symbol)
        {
            double result = default;

            switch (symbol)
            {
                case '+':
                    result = Sum(operandOne, operandTwo);
                    break;

                case '-':
                    result = Difference(operandOne, operandTwo);
                    break;

                case '*':
                    result = Multiply(operandOne, operandTwo);
                    break;

                case '/':
                    result = Divide(operandOne, operandTwo);
                    break;
            }

            return result;
        }

        #endregion

        #region Utils

        static string Input(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();

            return answer;
        }

        #endregion

        static void Main(string[] args)
        {
            string numberOne = Input("Enter operand one (number only)");

            if (double.TryParse(numberOne, out double number1))
            {
                string numberTwo = Input("Ente operand two (number only)");

                if (double.TryParse(numberTwo, out double number2))
                {
                    string @char = Input("Enter some mathematical symbol");

                    if (char.TryParse(@char, out char symbol))
                    {
                        double result = Calculator(number1, number2, symbol);
                        Console.WriteLine(result);
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
