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
            int charSize = sizeof(char);
            Console.WriteLine(charSize);

            int boolSize = sizeof(bool);
            Console.WriteLine(boolSize);

            int intSize = sizeof(int);
            Console.WriteLine(intSize);

            Console.ReadKey();
        }
    }
}
