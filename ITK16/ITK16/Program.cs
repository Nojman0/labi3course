using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ITK16

{

    class MyQueue<T>

    {

        T[] data;



        public T Data { get; set; }



        public MyQueue()

        {

            data = new T[0];

        }



        public void Enqueue(T item)

        {

            T[] newData = new T[data.Length + 1];

            for (int i = 0; i < data.Length; i++)

            {

                newData[i] = data[i];

            }
            newData[data.Length] = item;

            data = newData;

        }
        public static MyQueue<T> operator <(MyQueue<T> q, MyQueue<T> q1)

        {



            T[] newData = new T[q.data.Length + q1.data.Length];

            int help = 0;

            for (int i = 0; i < q.data.Length; i++)

            {

                newData[i] = q.data[i];

                help++;

            }

            for (int i = 0; i < q1.data.Length; i++)

            {

                newData[help] = q1.data[i];

                help++;

            }



            Array.Sort(newData);

            Array.Reverse(newData);

            MyQueue<T> q_new = new MyQueue<T>();

            q_new.data = newData;

            return q_new;

        }

        public static MyQueue<T> operator >(MyQueue<T> q, MyQueue<T> q1)

        {

            T[] newData = new T[q.data.Length + q1.data.Length];

            int help = 0;

            for (int i = 0; i < q.data.Length; i++)

            {

                newData[i] = q.data[i];

                help++;

            }

            for (int i = 0; i < q1.data.Length; i++)

            {

                newData[help] = q1.data[i];

                help++;

            }



            Array.Sort(newData);

            MyQueue<T> q_new = new MyQueue<T>();

            q_new.data = newData;

            return q_new;

        }



     



        public T Dequeue()

        {

            T[] newData = new T[data.Length - 1];

            T help;

            if (data != null)

            {

                help = data[0];

                for (int i = 0; i < newData.Length; i++)

                {

                    newData[i] = data[i + 1];

                }

                data = newData;

            }

            else

                throw new IndexOutOfRangeException();



            return help;

        }



        public T GetItem(int index)

        {

            if (index > -1 && index < data.Length)

            {

                return data[index];

            }

            else

                throw new IndexOutOfRangeException();

        }



        public int Count()

        {

            return data.Length;

        }



        public bool Bool()

        {

            if (data.Length > 0)

            {

                return true;

            }

            else

            {

                return false;

            }

        }



    }

    class Person

    {

        public string Name { get; set; }

    }

    class Program

    {

        static void Main(string[] args)

        {

            MyQueue<int> queue = new MyQueue<int>();

            MyQueue<int> queue_1 = new MyQueue<int>();



            queue.Enqueue(2);

            queue.Enqueue(3);

            queue_1.Enqueue(5);




            MyQueue<int> queue_new = new MyQueue<int>();

            queue_new = (queue < queue_1);

            int q_lenth = queue_new.Count();

            for (int i = 0; i < q_lenth; i++)

            {

                Console.WriteLine((queue_new));

            }

            Console.WriteLine("------------");

            queue_new = (queue > queue_1);

            q_lenth = queue_new.Count();

            for (int i = 0; i < q_lenth; i++)

            {

                Console.WriteLine((queue_new));

            }
            Console.ReadKey();
            //Console.WriteLine(queue.Bool());

        }

    }

}