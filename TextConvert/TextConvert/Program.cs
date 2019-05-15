using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; 
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace TextConvert
{
    class RandomDateTime
    {
        DateTime start;
        Random gen;
        int range;

        public RandomDateTime()
        {
            start = new DateTime(2019, 1, 1);
            gen = new Random();
            range = (DateTime.Today - start).Days;
        }

        public DateTime Next()
        {
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }
    }
    class Program
    {
        private static SqlConnection connection;
        private static SqlCommand command1 = new SqlCommand();
        static string imya = "imya.txt";
        static string fam = "fam.txt";
        static string otсh = "otch.txt";
        static string connectionString = @"Data source=DESKTOP-73JNOIS\SQLEXPRESS;Initial Catalog=pra4e4kaNaSteroidax;Integrated Security=True";
        static void initText()
        {
            Random rand = new Random();
            StreamReader im = new StreamReader(imya, System.Text.Encoding.UTF8);
            StreamReader fa = new StreamReader(fam, System.Text.Encoding.UTF8);
            StreamReader ot = new StreamReader(otсh, System.Text.Encoding.UTF8);
            List<String> imena = new List<String>();
            List<String> familii = new List<String>();
            List<String> otchestva = new List<String>();
            while (!im.EndOfStream)
            {
                imena.Add(im.ReadLine());
            }
            while (!fa.EndOfStream)
            {
                familii.Add(fa.ReadLine());
            }
            while (!ot.EndOfStream)
            {
                otchestva.Add(ot.ReadLine());
            }
            for (int i = 0; i < imena.Count; i++)
            {
                for (int j = 0; j < imena.ElementAt(i).Length; j++)
                {
                    bool delete = true;
                    for (int z = 'А'; z <= 'я'; z++)
                    {
                        if ((imena.ElementAt(i)[j] == (char)z) || (imena.ElementAt(i)[j] == '-') || (imena.ElementAt(i)[j] == ' '))
                        {
                            delete = false;
                            continue;
                        }
                    }
                    if (delete)
                    {
                        imena[i] = imena.ElementAt(i).Remove(j, 1);
                        j--;
                    }
                }
            }

            for (int i = 0; i < imena.Count; i++)
            {
                if (imena.ElementAt(i) == null);
                {
                    imena.RemoveAt(i);
                }
            }
            for (int i = 0; i < 1000; i++)
            {
                if (i < familii.Count)
                {
                    imena[i] = imena.ElementAt(rand.Next(0, imena.Count));
                    otchestva[i] = otchestva.ElementAt(rand.Next(0, otchestva.Count));
                    familii[i] = familii.ElementAt(rand.Next(0, familii.Count));
                }
                else
                {
                    imena.Add(imena.ElementAt(rand.Next(0, imena.Count)));
                    otchestva.Add(otchestva.ElementAt(rand.Next(0, otchestva.Count)));
                    familii.Add(familii.ElementAt(rand.Next(0, familii.Count)));
                }
                Console.WriteLine(imena.ElementAt(i) + " " + familii.ElementAt(i) + " " + otchestva.ElementAt(i));
            }

            Console.WriteLine(imena.Count);
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int temp = 0;
                int temp1 = 0;
                int []mas = { 50, 100, 25 };
                for (int i = 0; i < 100; i++) 
                {
                    temp1 = rand.Next(1, 4);
                    temp = rand.Next(1, 5);
                   int temp2 = temp1 - 1;
                    SqlMoney mon = new SqlMoney();
                    mon = (temp * mas[temp2]);
                    DateTime date;
                    RandomDateTime date1 = new RandomDateTime();
                    date = date1.Next();
                    Insert($"INSERT INTO dbo.Заказ VALUES ('{temp}', '{mon/100}', '{date}', '{rand.Next(1, 250)}','{temp1}','{rand.Next(1,1000)}','{rand.Next(1,3)}')");
                }
                Console.WriteLine("Подключение открыто");
            }
            Console.WriteLine("Подключение закрыто...");

        }
        static void Main(string[] args)
        {
            initText();
        }

       static public void Insert(string command)
        {
            command1.Connection = connection;
            command1.CommandText = command;
            command1.ExecuteNonQuery();
        }

    }
}
