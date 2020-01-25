using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 60;

            number = (byte)(number >> 4);
            Console.WriteLine(Convert.ToDecimal(number));

            Console.ReadKey();
        }
    }
}
