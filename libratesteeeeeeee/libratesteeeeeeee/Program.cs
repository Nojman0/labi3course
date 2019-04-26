using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASSLIBRAVNA2RE;
namespace libratesteeeeeeee
{
    class Program
    {
        static void Main(string[] args)
        {
            timer t = new timer();
            t.hour = 54;
            Console.WriteLine(t.day());
        }
    }
}
