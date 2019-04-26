using System;

namespace ConsoleApp4
{

    class Monkey
    {
        public string name;
        public string iq;
        public string skills;

        public void demo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("IQ: " + iq);
            Console.WriteLine("Умения: " + skills);
        }
        public Monkey(string name, string iq, string skills)
        {
            this.name = name;
            this.iq = iq;
            this.skills = skills;
        }


    }

    class AfterThenMonkey : Monkey
    {
        public AfterThenMonkey(string name, string iq, string skills) : base(name, iq, skills) { }
        public void demo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("IQ: " + iq);
            Console.WriteLine("Умения: " + skills);
        }
    }

    class NEDOPEOPLE : AfterThenMonkey
    {
        public NEDOPEOPLE(string name, string iq, string skills) : base(name, iq, skills) { }
        public void demo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("IQ: " + iq);
            Console.WriteLine("Умения: " + skills);
        }
    }

    class KOLYANOW : NEDOPEOPLE
    {
        public KOLYANOW(string name, string iq, string skills) : base(name, iq, skills) { }
        public void demo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("IQ: " + iq);
            Console.WriteLine("Умения: " + skills);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Monkey mk = new Monkey("Древний Коля", "Около 0", "Ну так, чисто палочкой подолбить");
            AfterThenMonkey amk = new AfterThenMonkey("Менее древний Коля", "Ну уже около десяточки", "Но по прежнему, только камушки долбит");
            NEDOPEOPLE ndp = new NEDOPEOPLE("Коля 90-х", "Около 30, всё таки пару нефтяных точек отжал на стрелках", "Строит из себя правельного гангстера");
            KOLYANOW kn = new KOLYANOW("Коля нынешний", "OVER THEN 60!", "Умеет программировать, танцует, играет в игры на компутере, даёт жизненные советы!!!");
            Console.WriteLine("------------------------------------------");
            mk.demo();
            Console.WriteLine("------------------------------------------");
            amk.demo();
            Console.WriteLine("------------------------------------------");
            ndp.demo();
            Console.WriteLine("------------------------------------------");
            kn.demo();
            Console.WriteLine("------------------------------------------");
            Console.ReadKey();
        }
    }
}
