using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK16 {
	class CVector<T> : IEnumerable<T>{
		int hour, minute, second;
		public int Hour {
		get => hour;
			 set {
				if ((value > 24) || (value < 0))
					throw new Exception("Wrong hour format!");
				else
					hour = value;
			}
		}
		public int Minute {
			get => minute;
			 set {
				if ((value > 60) || (value < 0))
					throw new Exception("Wrong hour format!");
				else minute = value;
			}
		}
		public int Second {
			get => second;
			 set {
				if ((value > 60) || (value < 0))
					throw new Exception("Wrong hour format!");
				else second = value;
			}
		}

		public CVector() {
			Hour = 0;
			Minute = 0;
			Second = 0;
		}

		public CVector(int h, int m, int s) {
			Hour = h;
			Minute = m;
			Second = s;
		}
		
		~CVector(){ Console.WriteLine("Distructor"); GC.Collect(); }

		public void AddToTime(ref int h, ref int m, ref int s){
			h += Hour;
			m += Minute;
			s += Second;
		}

		public void GetTime(){
			Console.WriteLine($"{Hour}:{Minute}:{Second}");
		}

		public int this[int index]{
		get {
			switch(index){

					case 0:return Hour;
					case 1: return Minute;
					case 2: return Second;
					default: throw new Exception("Wrong index");

				}
		}
			set {
				switch (index) {

					case 0: Hour = value;break;
					case 1: Minute = value; break;
					case 2:Second = value; break;
					default: throw new Exception("Wrong index");

				}
			}
		}
        public static CVector<T> operator++(CVector<T> current){
			CVector<T> tmp = new CVector<T>();
            tmp.Hour = current.Hour + 1;
            tmp.Minute = current.Minute + 1;
            tmp.Second = current.Second + 1;
			return tmp;
		}
        public static CVector<T> operator --(CVector<T> current)
        {
            CVector<T> tmp = new CVector<T>();
            tmp.Hour = current.Hour - 1;
            tmp.Minute = current.Minute - 1;
            tmp.Second = current.Second - 1;
            return tmp;
        }

		public static bool operator ==(CVector<T> left, CVector<T> right) {
			if((left.Hour == right.Hour) && (left.Minute == right.Minute)&&(left.Second == right.Second) )
				return true;
			return false;
		}

		public static bool operator !=(CVector<T> left, CVector<T> right) {
				return (left.Hour != right.Hour) || (left.Minute != right.Minute) || (left.Second != right.Second);
		}


		public override bool Equals(object obj) {
			var vector = obj as CVector<T>;
			return vector != null &&
				   Hour == vector.Hour &&
				   Minute == vector.Minute &&
				   Second == vector.Second;
		}

		public override int GetHashCode() {
			var hashCode = 1505761165;
			hashCode = hashCode * -1521134295 + Hour.GetHashCode();
			hashCode = hashCode * -1521134295 + Minute.GetHashCode();
			hashCode = hashCode * -1521134295 + Second.GetHashCode();
			return hashCode;
		}

		public IEnumerator<T> GetEnumerator() {
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			throw new NotImplementedException();
		}
    }
        class Program
        {
            static void Main(string[] args)
            {
                Queue<int> queue = new Queue<int>();

                //queue.Push(10);
                //queue.Push(100);
                //Console.WriteLine(queue.CurrentElement());
                //queue.Pop();
                //Console.WriteLine(queue.CurrentElement());
                //queue.Pop();
                //queue.Pop();
                //Console.WriteLine(queue.CurrentElement());


                CVector<int> time = new CVector<int>() { Hour = 2, Minute = 43, Second = 56 };
                CVector<int> time2 = new CVector<int>() { Hour = 2, Minute = 43, Second = 56 };

                time.GetTime();
                Console.WriteLine(time != time2);
                Console.WriteLine(time == time2);
                time++;
                time.GetTime();
                Console.WriteLine(time != time2);
                Console.WriteLine(time == time2);
                time--;
                time.GetTime();
                Console.WriteLine(time != time2);
                Console.WriteLine(time == time2);
            //foreach (var i in time)
            //	Console.WriteLine(i);


            Console.ReadKey();
            }
        }
    }
