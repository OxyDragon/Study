using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 60;

            number = (byte)(number << 2);
            Console.WriteLine(Convert.ToInt32(number));

            Console.ReadKey();
        }
    }
}
