using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void WriteName(string name)
        {
            Console.WriteLine("Owl " + name);
        }

        static void Main(string[] args)
        {
            WriteName("Oxy");

            Console.ReadKey();
        }
    }
}
