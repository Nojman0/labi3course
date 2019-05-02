using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace TRPOxBD
{
    class Program
    {
        private static SqlConnection connection;
        private static SqlCommand command1 = new SqlCommand();
        static string connectionString = @"Data source=DESKTOP-73JNOIS\SQLEXPRESS;Initial Catalog=TRPO;Integrated Security=True";
        static public void createUser()
        {
            User a = new User();
            Console.Write("Insert name of user: ");
            a.Name = Console.ReadLine();
            Console.Write("Insert Login: ");
            a.Login = Console.ReadLine();
            bool isFalse = false;
            while (!isFalse)
            {
                Console.Write("Insert Password: ");
                a.passwordHash = Hash(Console.ReadLine());
                Console.Write("Repeat Password: ");
                if (Hash(Console.ReadLine()) == a.passwordHash)
                {
                    isFalse = true;
                }
                else
                {
                    Console.WriteLine("Passwords not equal");
                }
            }
            a.roleId = 1;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                request($"INSERT INTO dbo.Пользователь(Имя,Логин,Хэш_Пароля,Код_Роли) VALUES('{a.Name}','{a.Login}','{a.passwordHash}',{a.roleId})");
            }
        }
        static public void signIn()
        {
            User a = new User();
            Console.Write("Insert Login: ");
            a.Login = Console.ReadLine();
            
        }
        public static string Hash(string password)
        {
            Byte[] innput = Encoding.UTF8.GetBytes(password);
            Byte[] hashB = SHA256.Create().ComputeHash(innput);
            return BitConverter.ToString(hashB);
        }
        static void Main(string[] args)
        {
            createUser();
        }
        static public void request(string command)
        {
            command1.Connection = connection;
            command1.CommandText = command;
            command1.ExecuteNonQuery();
        }
    }
}
