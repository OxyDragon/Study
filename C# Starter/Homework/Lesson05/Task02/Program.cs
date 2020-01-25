using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool name = true;
            bool secondName = false;

            if (name == true && secondName == false)
                Console.WriteLine("Correсt");
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
