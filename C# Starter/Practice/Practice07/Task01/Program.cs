using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static string Input(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();

            return answer;
        }

        static bool IsNumber(string text)
        {
            bool result = int.TryParse(text, out int numbText);

            return result;
        }
        static void Main(string[] args)
        {
            string answer = Input("Could you, please, enter some number?");

            bool isNumber = IsNumber(answer);
            if (isNumber)
                Console.WriteLine("Correct, that is a number!");
            else
                Console.WriteLine("Incorrect, that is not a number!");

            Console.ReadKey();
        }
    }
}
