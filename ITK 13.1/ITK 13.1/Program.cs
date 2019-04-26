using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double func(MyDelegate z, double x)
        {
            return z(x);
        }
        delegate double MyDelegate(Double x);
        static void Main(string[] args)
        {

            for (double x = -1; x <= 4; x++)
            {
                Console.WriteLine("x={0,4:f1} Atan={1} Cosh={2}", x, func(Math.Atan, x), func(Math.Cosh, x));
                Console.ReadKey();
            }
        }
    }
}
