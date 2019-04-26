using System.IO;
using System;

namespace Exception
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
            try
            {
                int z = 2 / i;
            }
            catch (DivideByZeroException e)


            { Console.WriteLine(("делить на 0 нельзя!")); }
            Console.WriteLine("ziiii");
            Console.ReadKey();
        }
    }
}
