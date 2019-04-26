using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2
{
    class Student
    {
        protected string fio;
        protected string fak;
        protected int course;
        protected int minMark;
        public Student(string fio, string fak, int course, int minMark)
        {
            this.fio = fio;
            this.fak = fak;
            this.course = course;
            this.minMark = minMark;
        }
        public virtual void lvlUp()
        {
            if (minMark >= 3)
            {
                course = course + 1;
            }
        }
        public virtual double stepyxa()
        {
            if (minMark == 5)
            {
                return 300;
            }
            if (minMark == 4)
            {
                return 200;
            }
            else
            {
                return 0;
            }
        }
        public void info()
        {
            Console.WriteLine("ФИО студента:" + fio);
            Console.WriteLine("Факультет студента:" + fak);
            Console.WriteLine("Курс студента:" + course);
            Console.WriteLine("Минимальная оценка по экзаменам:" + minMark);
        }
    }
    class ContractStudent : Student
    {
       private bool isPayed;
       public ContractStudent(string fio, string fak, int course, int minMark, bool isPayed) : base(fio, fak, course, minMark)
        {
            this.isPayed = isPayed;
        }
         public override void lvlUp()
         {
             if (isPayed == false)
            {
                return;
            }
             if (minMark >= 3)
             {
                 course = course + 1;
             }
             
         }
        public override double stepyxa()
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Dudez = new Student("Дудницкий ЕИ", "Программирование", 3, 4);
            ContractStudent Ivanov = new ContractStudent("Иванов ИИ", "Программирование", 3, 3, true);
            ContractStudent Sidorov = new ContractStudent("Сидоров СС", "Программирование", 3, 3, false);
            Dudez.info();
            Ivanov.info();
            Sidorov.info();
            Dudez.lvlUp();
            Ivanov.lvlUp();
            Sidorov.lvlUp();
            Dudez.info();
            Ivanov.info();
            Sidorov.info();
            Console.ReadKey();
        }
    }
}
