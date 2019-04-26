using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaForLox
{
    struct Train :IComparable<Train>
    {
        public string name;
        public int number;
        public int minute;
        public int hour;

       

        public int CompareTo(Train other)
        {
            if (this.hour > other.hour) return 1;
            if (this.hour < other.hour) return -1;
            return 0;
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Train[] trains = new Train[3];
            string travelloc;
            bool isLoc = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Train #" + (i + 1));
                Console.Write("TravelLoc:");
                trains[i].name = Console.ReadLine();
                Console.Write("numver of train:");
                trains[i].number = Int32.Parse(Console.ReadLine());
                Console.Write("Hour of train arrive:");
                trains[i].hour = Int32.Parse(Console.ReadLine());
                Console.Write("Minute of train arrive:");
                trains[i].minute = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Enter Travelloc:");
            travelloc = Console.ReadLine();
            Array.Sort(trains);
            for (int i = 0; i < 3; i++)
            {

                if (trains[i].name == travelloc)
                {
                    Console.WriteLine("Trainloc: " + trains[i].name);
                    Console.WriteLine("Train number: " + trains[i].number);
                    Console.WriteLine("Train coming time: " + trains[i].hour + ":" + trains[i].minute);
                    Console.WriteLine("-----------------------------------------");
                    isLoc = true; 
                }
            }
            if(isLoc==false)
            {
                Console.WriteLine("There are no trains to this trainloc.");
            }

        }
    }
}
