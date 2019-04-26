using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
  
            FileStream file = new FileStream("data.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            Regex myReg = new Regex(@"(^|\b)\.*(0\d|1\d|2[0-3]):[0-5][0-9]:[0-5][0-9](\s|\b|$)",
                RegexOptions.IgnoreCase);
            var strings = reader.ReadToEnd().Split(new char[] { '\n' }).Where(x => myReg.Matches(x).Count >= 2).ToList();
            Console.WriteLine("Количество строк, подходящих условию: ");
            Console.WriteLine(strings.Count);
            Console.WriteLine("\nСодержание этих строк: ");
            strings.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}