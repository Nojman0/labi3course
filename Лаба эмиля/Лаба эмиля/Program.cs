using System;
using System.Collections.Generic;
using System.Linq;

namespace ZKI3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Шифр Плейфера:");
            First();
            Console.WriteLine();
        }
        public static void First()
        {
            string word = "Весь алгоритм шифрования, кроме значения секретного ключа, известен криптоаналитикам противника".Replace("Ё", "Е").ToLower();
            Console.WriteLine(word);
            string crypted = string.Empty;
            char[,] matrixAlphabit = new char[4, 8];
            string alphabit = string.Empty;
            string keyWord = "КИНОТЕАТР".ToLower();
            List<string> bigrams = new List<string>();
            int index = 0;
            int chCounter = 0;
            for (int i = 0; i < keyWord.Length; i++)
            {
                if (!alphabit.Contains(keyWord[i]))
                {
                    alphabit += keyWord[i];
                }
            }
            char ch = 'а';
            while (ch <= 'я')
            {
                if (!alphabit.Contains(ch))
                {
                    alphabit += ch;
                }
                ch++;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrixAlphabit[i, j] = alphabit[index];
                    index++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrixAlphabit[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == word[i - 1])
                {
                    word = word.Insert(i, "ъ");
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'а' && word[i] <= 'я')
                {
                    chCounter++;
                }
            }
            if (chCounter % 2 != 0)
            {
                word += "ъ";
            }
            string strBigrams = string.Empty;
            string bigram = string.Empty;
            for (int i = 0; i < word.Length; i++)

            {
                if (word[i] >= 'а' && word[i] <= 'я')
                {
                    bigram += word[i];
                }
                if (bigram.Length == 2)
                {
                    bigrams.Add(bigram + " ");
                    bigram = string.Empty;
                }
            }

            int i_1 = 0, i_2 = 0, j_1 = 0, j_2 = 0;
            for (int k = 0; k < bigrams.Count; k++)
            {
                bigram = bigrams[k];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (matrixAlphabit[i, j] == bigram[0])
                        {
                            i_1 = i;
                            j_1 = j;
                        }
                        if (matrixAlphabit[i, j] == bigram[1])
                        {
                            i_2 = i;
                            j_2 = j;
                        }
                    }
                }
                if (i_1 == i_2)
                {
                    if (j_1 == 7)
                    {
                        crypted += matrixAlphabit[i_1, 0];
                        crypted += matrixAlphabit[i_2, j_2 + 1];
                    }

                    else if (j_2 == 7)
                    {
                        crypted += matrixAlphabit[i_1, j_1 + 1];
                        crypted += matrixAlphabit[i_2, 0];
                    }
                    else
                    {
                        crypted += matrixAlphabit[i_1, j_1 + 1];
                        crypted += matrixAlphabit[i_2, j_2 + 1];
                    }
                }

                else if (j_1 == j_2)
                {
                    if (i_1 == 3)
                    {
                        crypted += matrixAlphabit[0, j_1];
                        crypted += matrixAlphabit[i_2 + 1, j_2];
                    }
                    else if (i_2 == 3)
                    {
                        crypted += matrixAlphabit[i_1 + 1, j_1];
                        crypted += matrixAlphabit[0, j_2];
                    }
                    else
                    {
                        crypted += matrixAlphabit[i_1 + 1, j_1];
                        crypted += matrixAlphabit[i_2 + 1, j_2];
                    }
                }
                else if ((i_1 != i_2) && (j_1 != j_2))
                {
                    crypted += matrixAlphabit[i_1, j_2];
                    crypted += matrixAlphabit[i_2, j_1];
                }

                crypted += " ";
            }
            Console.WriteLine(word);
            foreach (string item in bigrams)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n" + crypted);
            Console.ReadLine();
        }
    }
}