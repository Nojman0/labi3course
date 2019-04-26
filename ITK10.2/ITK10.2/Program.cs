using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK10
{
    //8   - т – Треугольник,кввадрата (данные - стороны)
    // 16  - Линия – Прямоугольник (данные-координаты)
    abstract class Figure
    {
        public abstract void Enter();
        public abstract void Viv();
        public abstract void Viv1();
        public virtual void Square() { }
        public virtual void Square1() { }
        public virtual void Volume() { }
    }
    class Line : Figure
    {
        public int a;
        public int b;
        public int c;
        public int shirina;
        public int dlina;


        public override void Enter()
        {
            Console.WriteLine("Введите стороны начала и конца(a) квадрата: ");
            a = Convert.ToInt32(Console.ReadLine());

        }
        public override void Viv()
        {
            Console.WriteLine($"Стороны линии = ({a};)");
        }
        public override void Viv1()
        {
            Console.WriteLine($"Стороны квадрата = ({a};)");
        }
    }
    class Rectangle : Figure
    {
        public int a;
        public int b;
        public int c;
        public int shirina;
        public int dlina;
        public override void Enter()
        {
            Console.WriteLine("Введите координаты начала и конца(a, b, c, ширина,длина) треугольника: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            shirina = Convert.ToInt32(Console.ReadLine());
            dlina = Convert.ToInt32(Console.ReadLine());


        }
        public override void Viv()
        {
            Console.WriteLine($"Координаты треугольника = ({a}; {b}), ({c};)({shirina});(dlina)");
        }
        public override void Square()
        {

            Console.WriteLine("Площадь треугольника = " + ((0.5 * shirina) * dlina));
        }

        public override void Viv1()
        {
            Console.WriteLine($"Координаты квадрата = ({a}; ");
        }
        public override void Square1()
        {

            Console.WriteLine("Площадь квадрата = " + Math.Pow(a, 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            int count = 0;
            Line ln = new Line();
            Rectangle rc = new Rectangle();
            ln.Enter();
            ln.Viv();
            rc.Enter();

            rc.Square1();
            rc.Viv1();
            count++;
            if (count == 1)
                if (a + b <= c || a + c <= b || b + a <= a)
                {
                    rc.Viv();
                    ln.Viv1();
                    rc.Square();
                }
                else
                {

                    Console.WriteLine("Треугольник не может быть построен т.к сумма двух сторон не может быть меньше или равна третей стороны");
                }


            Console.ReadKey();
        }
    }
}
