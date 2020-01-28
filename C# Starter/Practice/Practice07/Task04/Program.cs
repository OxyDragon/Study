using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void ProceedFormula(ref double x, out double y)
        {
            y = 0;

            for (int i = 5; i < 13; i++)
            {
                y += (i + Math.Pow(x, i));
            }
        }
        static void Main(string[] args)
        {
            double x = 5;

            ProceedFormula(ref x, out double y);
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
