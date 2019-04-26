using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace floydcsharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int inf = 99;
            int[,] adjMatrix = new int[n, n] {
        { 0, 3, inf, inf, inf, inf, inf, inf, inf, 10 },
        { 3, 0, 6, inf, inf, inf, inf, inf, inf, inf },
        { inf, 6, 0, 2, inf, inf, inf, inf, inf, inf },
        { inf, inf, 2, 0, 7, inf, inf, inf, inf, inf },
        { inf, inf, inf, 7, 0, 8, inf, inf, inf, inf },
        { inf, inf, inf, inf, 8, 0, 9, inf, inf, inf },
        { inf, inf, inf, inf, inf, 9, 0, 7, inf, inf },
        { inf, inf, inf, inf, inf, inf, 7, 0, 3, inf },
        { inf, inf, inf, inf, inf, inf, inf, 3, 0, 6 },
        { 10, inf, inf, inf, inf, inf, inf, inf, 6, 0 }
        };
            int[,] MatrixOfWays = {  { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                          { 1, 0, 3, 4, 5, 6, 7, 8, 9, 10 },
                          { 1, 2, 0, 4, 5, 6, 7, 8, 9, 10 },
                          { 1, 2, 3, 0, 5, 6, 7, 8, 9, 10 },
                          { 1, 2, 3, 4, 0, 6, 7, 8, 9, 10 },
                          { 1, 2, 3, 4, 5, 0, 7, 8, 9, 10 },
                          { 1, 2, 3, 4, 5, 6, 0, 8, 9, 10 },
                          { 1, 2, 3, 4, 5, 6, 7, 0, 9, 10 },
                          { 1, 2, 3, 4, 5, 6, 7, 8, 0, 10 },
                          { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 } };
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((adjMatrix[i, k] + adjMatrix[k, j]) < adjMatrix[i, j])
                        {
                            adjMatrix[i, j] = adjMatrix[i, k] + adjMatrix[k, j];
                            MatrixOfWays[i, j] = k + 1;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(adjMatrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(MatrixOfWays[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Номер шага " + (k + 1));
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(adjMatrix[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(MatrixOfWays[i, j] + " ");
                }
                Console.WriteLine();
            }
            int Pstart = int.Parse(Console.ReadLine()) - 1;
            int Pend = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Length: " + adjMatrix[Pstart, Pend]);
            for (int i = Pend; ;)
            {
                if (i != Pend)
                {
                    Console.Write("<-");
                }
                Console.Write(i + 1);
                if (MatrixOfWays[(MatrixOfWays[Pstart, i] - 1), i] != inf && MatrixOfWays[(MatrixOfWays[Pstart, i] - 1), i] != i + 1 && MatrixOfWays[(MatrixOfWays[Pstart, i] - 1), i] != 0)
                {
                    Console.Write("<-" + MatrixOfWays[(MatrixOfWays[Pstart, i] - 1), i]);
                }
                i = (MatrixOfWays[Pstart, i] - 1);
                if (i == (MatrixOfWays[Pstart, i] - 1))
                {
                    Console.Write("<-" + (i + 1));
                    break;
                }
            }
            Console.Write("<-" + (Pstart + 1));
            Console.ReadKey();
        }
    }
}