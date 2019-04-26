using System.IO;
using System;

namespace ConsoleApplication1
{
    class Program
    {

        public class Workers
        {
            protected int n = 0;
            protected string[] Name;
            protected string[] Surname;
            protected string[] ID;
            protected string[] Worker_Type;
            protected double[] Zp;
            public Workers(int n, string Name, string Surname, string ID, string Worker_Type, double Zp)
            {
                this.n = n;
                this.Name[n] = Name;
                this.Surname[n] = Surname;
                this.ID[n] = ID;
                this.Worker_Type[n] = Worker_Type;
                this.Zp[n] = Zp;

            }

        }

        class pochas_opl : Workers
        {
            public double[] Otr_chas;
            public pochas_opl(int Otr_chas, int n, string Name, string Surname, string ID, string Worker_Type, double Zp) : base(n, Name, Surname, ID, Worker_Type, Zp)
            {
                this.Otr_chas[n] = Otr_chas;
            }

            public void mass_ms()
            {
                Console.WriteLine("Количество рабочих с почасовой оплатой = {0} ", n);
                Console.WriteLine("Заполните данные о сотрудниках: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Имя: ");
                    Name[i] = Console.ReadLine();
                    Console.WriteLine("Фамилия: ");
                    Surname[i] = Console.ReadLine();
                    Console.WriteLine("Индификационный номер рабочего: ");
                    ID[i] = Console.ReadLine();
                    Console.WriteLine("Количество отработанных часов: ");
                    Otr_chas[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            public void check_mass()
            {
                Console.WriteLine("Список рабочих с почасовой оплатой: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Ф.И.О: {0} {1}", Name[i], Surname[i]);
                    Console.WriteLine("Индификатор: {0} ", ID[i]);
                    Console.WriteLine("Зароботная плата: ", Zp[i]);
                }
            }
            public void Zp_rasch()
            {
                for (int i = 0; i < n; i++)
                {
                    Zp[i] = 20.8 * 8 * Otr_chas[i];
                }
            }
            public void Vivod()
            {
                double min = -999;
                for (int i = 0; i < n; i++)
                {
                    if (min > Zp[i])
                    {
                        min = Zp[i];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (Zp[i] == min)
                    {
                        Console.WriteLine("Человек с минимальной ЗП: ");
                        Console.WriteLine("Ф.И.О: {0} {1}", Name[i], Surname[i]);
                        Console.WriteLine("Индификатор: {0} ", ID[i]);
                        Console.WriteLine("Зароботная плата: ", Zp[i]);
                    }

                }
            }
        }

        class Pomes_opl : Workers
        {
            protected int n1;
            public Pomes_opl(int n1, int n, string Name, string Surname, string ID, string Worker_Type, double Zp) : base(n, Name, Surname, ID, Worker_Type, Zp)
            {
                this.n1 = n1;
            }

            public void mass_ms1()
            {
                Console.WriteLine("Оплата за день равна 30$ ");
                Console.WriteLine("Количество рабочих с ежемесечной оплатой = {0} ", n1);
                Console.WriteLine("Заполните данные о сотрудниках: ");
                for (int i = 0; i < n1; i++)
                {
                    Console.WriteLine("Имя: ");
                    Name[i] = Console.ReadLine();
                    Console.WriteLine("Фамилия: ");
                    Surname[i] = Console.ReadLine();
                    Console.WriteLine("Индификационный номер рабочего: ");
                    ID[i] = Console.ReadLine();
                }
            }
            public void check_mass()
            {
                Console.WriteLine("Список рабочих с ежемесячной оплатой: ");
                for (int i = 0; i < n1; i++)
                {
                    Console.WriteLine("Ф.И.О: {0} {1}", Name[i], Surname[i]);
                    Console.WriteLine("Индификатор: {0} ", ID[i]);
                    Console.WriteLine("Зароботная плата: ", Zp[i]);
                }
            }
            public void Zp_rasch()
            {
                for (int i = 0; i < n; i++)
                {
                    Zp[i] = 31 * 30;
                }
            }
            public void Vivod()
            {
                double min = -999;
                for (int i = 0; i < n; i++)
                {
                    if (min > Zp[i])
                    {
                        min = Zp[i];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (Zp[i] == min)
                    {
                        Console.WriteLine("Человек с минимальной ЗП: ");
                        Console.WriteLine("Ф.И.О: {0} {1}", Name[i], Surname[i]);
                        Console.WriteLine("Индификатор: {0} ", ID[i]);
                        Console.WriteLine("Зароботная плата: ", Zp[i]);
                    }

                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество работников: ");
            pochas_opl p_l = new pochas_opl(0, Convert.ToInt32(Console.ReadLine()), "", "", "", "", 0);
            p_l.mass_ms();
            p_l.check_mass();
            p_l.Zp_rasch();
            p_l.Vivod();
            Console.WriteLine("Введите количество работников: ");
            Pomes_opl p_m = new Pomes_opl(Convert.ToInt32(Console.ReadLine()), 0, "", "", "", "", 0);
            p_m.mass_ms1();
            p_m.check_mass();
            p_m.Zp_rasch();
            p_m.Vivod();
        }
    }
}
