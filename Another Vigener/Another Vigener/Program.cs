using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Vigener
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string key;
            string encripted = "";
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            str = "Ехал грека через реку";
            key = "Дудницкий";
            str = str.ToLower();
            key = key.ToLower();
            key = key.Replace("\n", string.Empty);
            str = str.Replace(" ", string.Empty);
            str = str.ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                int posStr = alphabet.IndexOf(str[i]);
                int posKey = alphabet.IndexOf(key[i % key.Length]);
                encripted += alphabet[(posKey + posStr) % (alphabet.Length - 1)];
            }

            Console.WriteLine(str);
            Console.WriteLine(encripted);
            Console.ReadKey();
        }
    }
}
