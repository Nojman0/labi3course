using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2S2P
{
    class Popka
    {

        static int Main(string[]args)
        {
            int popa(int ass)
            {
                Console.WriteLine(popa(3) + 1 + "popa");
                return popa(3);
            }
            Console.WriteLine(popa(4));
            return popa(4);
        }
    }
}
