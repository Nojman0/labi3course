using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatMod13
{
    class Program
    {
        static void Main(string[] args)
        {

        metka:
            int count = 0;
            try
            {
                Console.Write("Введите номер задания: ");
                count = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите число!");
                goto metka;
            }
            Console.Clear();
            switch (count)
            {
                case 1: { First(); goto metka; }
                case 2: { Second(); goto metka; }
                case 3: { Third(); goto metka; }
                default: { break; }
            }

        }

        public static void First()
        {
            Random rand = new Random();
            int k = 0;
            int i = 1;
            double sf, sk, x, y;
            Console.Write("Введите а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                x = rand.Next(0, 1000);
                x /= 1000;
                x *= a;
                y = rand.Next(0, 1000);
                y /= 1000;
                y *= a;
                if (y <= a - x && y >= 0 && x >= 0)
                {
                    k += 1;
                }
                i += 1;
            }

            sk = a * a;
            sf = sk * k / n;
            Console.WriteLine("Площадь = " + sf);
        }

        public static void Second()
        {
            Random rand = new Random();
            Console.Write("Введите радиус: ");
            int R = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int k = 0;

            double x;
            double y;


            for (int i = 1; i < n; i++)
            {
                x = rand.Next(-1000, 1000);
                x /= 1000;
                x *= R;
                y = rand.Next(-1000, 1000);
                y /= 1000;
                y *= R;
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
                {
                    k += 1;
                }

            }

            double sk = (R * 2) * (R * 2);
            double sf = sk * k / n;
            Console.WriteLine("Площадь: " + sf);
        }

        public static void Third()
        {
            Random rand = new Random();
            int k = 0;
            int i = 1;
            double sf, sk, x, y;
            Console.WriteLine("а = 2");
            double a = 2;
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                x = rand.Next(0, 1000);
                x /= 1000;
                x *= a;
                y = rand.Next(0, 1000);
                y /= 1000;
                y *= a;
                if (x + y <= 2 && x + y >= 1 && x >= 0 && y >= 0)
                {
                    k += 1;
                }
                i += 1;
            }

            sk = a * a;
            sf = sk * k / n;
            Console.WriteLine("Площадь = " + sf);
        }

        //public static void Individual()
        //{
        //    int n = 3;
        //    double[] r = new double[n];
        //    double[] x = new double[n];
        //    double[] y = new double[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write("Введите радиус {0}-й окружности: ", (i + 1));
        //        r[i] = double.Parse(Console.ReadLine());
        //    }

        //    double xmin, xmax, ymin, ymax, dx, dy;

        //    x[0] = double.Parse(Console.ReadLine());
        //    xmin = x[0] - r[0];
        //    xmax = x[0] + r[0];
        //    for (int i = 1; i < n; i++)
        //    {
        //        x[i] = double.Parse(Console.ReadLine());
        //        if (x[i] - r[i] < xmin) xmin = x[i] - r[i];
        //        if (x[i] + r[i] > xmax) xmax = x[i] + r[i];
        //     }

        //    dx = xmax - xmin;


        //    y[0] = double.Parse(Console.ReadLine());
        //    ymin = y[0] - r[0];
        //    ymax = y[0] + r[0];
        //    for (int i = 1; i < n; i++)
        //    {
        //        y[i] = double.Parse(Console.ReadLine());
        //        if (y[i] - r[i] < ymin) ymin = y[i] - r[i];
        //        if (y[i] + r[i] > ymax) ymax = y[i] + r[i];
        //    }

        //    dy = ymax - ymin;

        //    Random rand = new Random();

        //    int points = 10000;
        //    int insidepoints = 0;


        //    for (int i = 0; i < points; i++)
        //    {
        //        double pointx = xmin + dx;
        //        double pointy = ymin + dy;

        //        bool inside = true;

        //        for (int j = 0; j < n; j++)
        //        {
        //            if ()
        //            {
        //                inside = false;
        //                break;
        //            }
        //        }
        //    }

        //}

    }
}

