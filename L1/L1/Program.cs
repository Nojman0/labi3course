using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Mas
    {
        private readonly double Fount;
        private Mas(double Fount)
        {
            this.Fount = Fount;
        }
        public static Mas createFount(double fount)
        {
            return new Mas(fount);
        }
        public static Mas createGramm(double Gramm)
        {
            return new Mas((double)(Gramm / 453.49237));
        }
        public static Mas createUncia(double Uncia)
        {
            return new Mas((double)(Uncia / 16));
        }
        public Mas Add(Mas a)
        {
            return new Mas(this.Fount + a.Fount);
        }

        public Mas Sub(Mas a)
        {
            return new Mas(this.Fount - a.Fount);
        }
        public double Gramm => (double)(Fount * 453.49237);

        public double Uncia => (double)(Fount * 16);

        public double Founts => (double)(Fount);
        override public string ToString()
        {
            return String.Format("Fount: {0}; Uncia: {1}; Gramm: {2}.", this.Fount, (double)(Fount * 16), (double)(Fount * 453.49237));
        }
        /*
          public double fount;
          public double gramm;
          public double uncia;

          public Mas()
          {
              fount = 0;
              gramm = 0;
              uncia = 0;
          }
          public double inGramm()
          {
              return gramm = fount * 453.59237;
          }
         public double inUncia()
          {
              return uncia = fount / 16;
          }
          public double FromGrammToFount()
          {
              return fount = gramm / 453.49237;
          }
          public double FromUnciaToFount()
          {
              return fount = uncia * 16;
          }
          public static Mas operator +(Mas A1, Mas A2)
          {
              Mas B1 = new Mas();
              B1.fount = A1.fount + A2.fount;
              B1.gramm = A1.gramm + A2.gramm;
              B1.uncia = A1.uncia + A2.uncia;
              return B1;
          }
          public static Mas operator -(Mas A1, Mas A2)
          {
              Mas B1 = new Mas();
              B1.fount = A1.fount - A2.fount;
              B1.gramm = A1.gramm - A2.gramm;
              B1.uncia = A1.uncia - A2.uncia;
              return B1;
          }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Mas a = Mas.createFount(30);
            Mas b = Mas.createGramm(20000);

            Mas c = a.Add(b);
            Mas d = b.Sub(a);


            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(a.Founts);
            Console.WriteLine(d.Gramm);
            Console.ReadKey();
        }
    }
}
