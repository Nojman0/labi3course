using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data.SqlClient;
namespace TextConvert
{
    class Program
    {
        private static SqlConnection connection;
        private static SqlCommand command1 = new SqlCommand();
        static string inp = "in.txt";
        static string outp = "out.txt";
        static string connectionString = @"Data source=DESKTOP-F17302F\SQLEXPRESS;Initial Catalog=pra4e4ka;Integrated Security=True";
        static void initText()
        {
            StreamReader sr = new StreamReader(inp, System.Text.Encoding.UTF8);
            List<String> colors = new List<String>();
            while (!sr.EndOfStream)
            {
                colors.Add(sr.ReadLine());
            }
            for (int i = 0; i < colors.Count; i++)
            {
                // Console.WriteLine(colors.ElementAt(i));
            }
            for (int i = 0; i < colors.Count; i++)
            {
                for (int j = 0; j < colors.ElementAt(i).Length; j++)
                {
                    bool delete = true;
                    for (int z = 'А'; z <= 'я'; z++)
                    {
                        if ((colors.ElementAt(i)[j] == (char)z) || (colors.ElementAt(i)[j] == '-') || (colors.ElementAt(i)[j] == ' '))
                        {
                            delete = false;
                            continue;
                        }
                    }
                    if (delete)
                    {
                        colors[i] = colors.ElementAt(i).Remove(j, 1);
                        j--;
                    }
                }
            }
            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine(colors.ElementAt(i));
            }
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var item in colors)
                    Insert($"INSERT INTO dbo.Цвет VALUES ('{item}')");
                    Console.WriteLine("Подключение открыто");
            }
            Console.WriteLine("Подключение закрыто...");
            Console.WriteLine(colors.Count);

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
