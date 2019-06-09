using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testirovanie
{
    public class SumService
    {
        public int Sum(int arg1, int arg2)
        {
            var result = arg1 + arg2;
            AllOperationsSum += result;
            return result;
        }
        public int AllOperationsSum { get; set; }
    }

}
