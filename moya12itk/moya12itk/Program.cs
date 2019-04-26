using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ИТК_10
{
        class Program
        {
            public static void Sort(List<Task4.Worker> obj)
            {
                Task4.Worker[] temp = new Task4.Worker[5];
                double _temp;
                double[] array = new double[obj.Count];
                for (int i = 0; i < obj.Count; i++)
                {
                    array[i] = obj[i].Sellary;
                }
                for (int i = 0; i < obj.Count - 1; i++)
                {
                    for (int j = 0; j < obj.Count - i - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            _temp = array[j];
                            temp[j] = obj[j];

                            array[j] = array[j + 1];
                            obj[j] = obj[j + 1];

                            array[j + 1] = _temp;
                            obj[j + 1] = temp[j];
                        }
                    }

                }
            }
            public static void ShowFirstFive(List<Task4.Worker> obj)
            {
                if (obj.Count < 5)
                {
                    Console.WriteLine("В этом списке работников меньше пяти");
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(obj[i].Name);
                    }
                }
            }
            public static void ShowLastThree(List<Task4.Worker> obj)
            {
                for (int i = obj.Count - 3; i < obj.Count; i++)
                {
                    Console.WriteLine(obj[i].Name);
                }
            }
            static void Main(string[] args)
            {
               
                List<Task4.Worker> lw = new List<Task4.Worker>
                {
                    new Task4.WorkerWithFixedPayment(270) { Name = "Vlad", Surename = "Blinov" },
                    new Task4.WorkerWithFixedPayment(350) { Name = "Edik", Surename = "Sidorenko" },
                    new Task4.WorkerWithHourlyPayment(2) { Name = "Yegor", Surename = "Dundnitsky" },
                    new Task4.WorkerWithFixedPayment(80) { Name = "Alex", Surename = "Bezmen" }
                };
                for (int i = 0; i < lw.Count; i++)
                {
                    Console.WriteLine(lw[i].Name + " " + lw[i].Sellary);
                }
                Sort(lw);
                Console.WriteLine();
                for (int i = 0; i < lw.Count; i++)
                {
                    Console.WriteLine(lw[i].Name + " " + lw[i].Sellary);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
    class Task4
    {
        public abstract class Worker : IComparable
        {
        public double Sellary { get; protected set; } = 100;
            public string Name { get; set; }
            public string Surename { get; set; }
            public abstract double CalculateSellary();
            public int CompareTo(object obj)
            {
                return Sellary.CompareTo(obj);
            }
        }
        public class WorkerWithHourlyPayment : Worker
        {
            readonly double HourlyBet;
            public WorkerWithHourlyPayment(double HourlyBet)
            {
                this.HourlyBet = HourlyBet;
                this.Sellary = CalculateSellary();
            }
            public override double CalculateSellary()
            {
                return 20.8 * 8 * HourlyBet;
            }
        }
        public class WorkerWithFixedPayment : Worker
        {
            public WorkerWithFixedPayment(double Sellary)
            {
                this.Sellary = CalculateSellary();
            }
            public override double CalculateSellary()
            {
                return Sellary;
            }
        }
    }
