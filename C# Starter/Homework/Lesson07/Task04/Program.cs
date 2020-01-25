using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static double RaiseToPower(int number, int power = 2)
        {
            double result = Math.Pow(number, power);

            return result;
        }

        static void Main(string[] args)
        {
            int number = 3;
            int power = 6;

            double mathPower = RaiseToPower(number, power);
            Console.WriteLine(mathPower);

            Console.ReadKey();
        }
    }
}
