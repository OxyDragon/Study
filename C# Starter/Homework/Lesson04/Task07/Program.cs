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
            int x = 4, y = 2, j = 7, k = 3;
            int result = x > y ? (j > k ? j - k : j + k) : 0;

            Console.ReadKey();
        }
    }
}
