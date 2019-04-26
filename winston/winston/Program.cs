using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidjenetr
{
    /* class Program
     {
         static void Main(string[] args)
         {

             string alph =  "";
             string alph2 = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
             string text = " съешьещеэтихмягкихфранцузскихбулокдавыпейжечаю.";
             string key = "дудницкий";
             string key2 = "егор";

             char[,] table1 = new char[4, 8];
             char[,] table2 = new char[4, 8];
             key = key.ToLower();
             key2 = key2.ToLower();
             text = text.ToLower();
             for (int i = 0; i < text.Length; i++ )
             {
                 bool delete = true;
                 for (int j = 'а'; j <= 'я'; j++)
                 {
                     if (text[i] == (char)j)
                     {
                         delete = false;
                         continue;
                     }

                 }
                 if (delete)
                 {
                     text = text.Remove(i, 1);
                     i--;
                 }
             }
             char[] arrkey = key.ToCharArray();
             arrkey = arrkey.Distinct().ToArray(); //удаление повторений в 1 ключе
             for (int j = 0; j < arrkey.Length; j++)
             {
                 alph = alph.Replace(arrkey[j].ToString(), "");
             }

             Console.WriteLine(alph);

             char[] arrkey2 = key2.ToCharArray();
             arrkey2 = arrkey2.Distinct().ToArray(); //удаление повторений в 1 ключе

             for (int j = 0; j < arrkey2.Length; j++)
             {
                 alph2 = alph2.Replace(arrkey2[j].ToString(), "");
             }

             Console.WriteLine(alph2);

             key = new string(arrkey);
             Console.WriteLine(key);

             key2 = new string(arrkey2);
             Console.WriteLine(key2);

             alph = key + alph; //готовый первый алфавит
             alph2 = key2 + alph2;//готовый второй алфавит 

             char[] arralph = alph.ToCharArray();
             char[] arralph2 = alph2.ToCharArray();
             Console.WriteLine();
             int count = 0;
             int count2 = 0;

             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 8; j++)
                 {
                     table1[i, j] = arralph[count];
                     count++;

                 }

             }

             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 8; j++)
                 {
                     Console.Write(table1[i, j]);
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();


             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 8; j++)
                 {
                     table2[i, j] = arralph2[count2];
                     count2++;

                 }

             }

             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 8; j++)
                 {
                     Console.Write(table2[i, j]);
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();



             char[] charText;
             if (text.Length % 2 == 0)
             {
                 charText = text.ToCharArray();
             }
             else
             {
                 charText = new char[text.Length + 1];
                 charText = text.ToCharArray();
                 charText[charText.Length - 1] = 'ъ';
             }

             for (int i = 0; i + 1 < charText.Length; i += 2)
             {

                 int r = 0, c = 0, r2 = 0, c2 = 0;
                 //ищем позиции букв биграмм в таблицах
                 int found = 0;
                 for (int i2 = 0; i2 < 4; i2++)
                 {
                     for (int j2 = 0; j2 < 8; j2++)
                     {
                         if (charText[i] == table1[i2, j2])
                         {
                             r = i2; c = j2; found++;
                         }
                         if (charText[i + 1] == table2[i2, j2])
                         {
                             r2 = i2; c2 = j2; found++;
                         }
                     }
                 }
                 charText[i] = table2[r, c2];
                 charText[i + 1] = table1[r2, c];

             }

             for (int i = 0; i < charText.Length; i++)
             {
                 Console.Write(charText[i]);
             }

             Console.WriteLine();

             Console.ReadKey();
         }


     }*/
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string key;
            string encripted = "";
            string alphabet = "abcdefghijklmnopqrstuvexyz";

            str = Console.ReadLine();
            key = Console.ReadLine();

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
            
        }
    }
}
