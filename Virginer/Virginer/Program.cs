using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biba
{
    class Program
    {
        static void Main(string[] args)
        {

            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string text = "Cъешь еще этих мягких французских булок да выпей же чаю";
            text = text.ToLower();
            string key = "дудницкий";
             key = key.ToLower();
             for (int i = 0; i < text.Length; i++)
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
             for (int i = 0; i < key.Length; i++)
             {
                 bool delete = true;
                 for (int j = 'а'; j <= 'я'; j++)
                 {
                     if (key[i] == (char)j)
                     {
                         delete = false;
                         continue;
                     }
                 }
                 if (delete)
                 {
                     key = key.Remove(i, 1);
                     i--;
                 }
             }
             char[] keyarr = key.ToCharArray();
             char[] alpharr = alph.ToCharArray();
             char[] textarr = text.ToCharArray();
             int intkey = 0;
             int indexkey = 0;
             int indextext = 0;
             int score = 0;
             for (int i = 0; i < textarr.Length; i++)
             {
                 for (int j = 0; j < alpharr.Length; j++)
                 {
                     if (textarr[i] == alpharr[j])
                     {
                         indextext = j;
                         break;
                     }
                 }
                 if (intkey > key.Length - 1)
                 {
                     intkey = 0;
                 }

                 for (int k = 0; k < alpharr.Length; k++)
                 {
                     if (keyarr[intkey] == alpharr[k])
                     {
                         indexkey = k;
                         break;
                     }
                 }
                 intkey++;
                 score = indextext + indexkey;
                 if (score > alpharr.Length - 1)
                 {
                     score = score - 31;
                 }
                 textarr[i] = alpharr[score];
                 Console.Write(textarr[i]);
             }
             Console.WriteLine();
             Console.Read();
         }
         /*
            string result = "";
            char[] alpharr = alph.ToCharArray();
            int key_index = 0;
            foreach (char symbol in text)
            {
                int c = (Array.IndexOf(alpharr, symbol) +
                    Array.IndexOf(alpharr, key[key_index])) % alph.Length;
                result += alpharr[c];
                key_index++;

                if ((key_index + 1) == key.Length)
                    key_index = 0;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
     */   
    }
}
