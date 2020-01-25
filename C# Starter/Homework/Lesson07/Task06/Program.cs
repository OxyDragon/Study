using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static bool CanConvertStringToNumber(string operand)
        {
            bool result = true;

            if (int.TryParse(operand, out int number))
                Console.WriteLine(number);
            else
            {
                Console.WriteLine("ERROR");

                result = false;
            }

            return result;
        }

        static void Main(string[] args)
        {
            bool operand = CanConvertStringToNumber("12");
            Console.WriteLine(operand);

            Console.ReadKey();
        }
    }
}
