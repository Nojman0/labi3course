using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class X
    {
        public int x1;
        public int x2;
        public X()
        {
            Enter();
            Viv();
        }
        public void Enter()
        {
            Console.WriteLine("Введите значения x1 и x2: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
        }
        public void Viv()
        {
            Console.WriteLine($"Значение x1 = {x1}\nЗначение x2 = {x2}");
        }
    }
    class Y : X
    {
        int y;
        public Y() : base()
        {
            Enter();
            Viv();
        }
        public new void Enter()
        {
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public new void Viv()
        {
            Console.WriteLine($"Значение y = {y}");
        }
        public void Run()
        {
            //16	Значение x1-x2*(cos(y))
            //х1+ х2*у
            Console.WriteLine("Результат = " + (x1 + x2 * y));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Y new_res = new Y();
            new_res.Run();
            Console.ReadKey();
        }
    }
}
