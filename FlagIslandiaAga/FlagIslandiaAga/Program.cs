using System;


namespace FlagIslandiaAga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;


            for (double i = 0; i < 10; i = i + 0.5)
            {
                for (double j = 0; j < 40; j += 0.5) 
                {
                    if ((i > 3 && i < 6.5) || (j > 6.5 && j < 13))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.White;
                        if ((i >= 4 && i <=5.5) || (j >= 8 && j <= 11.5))
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    // Console.Write('\u25a0');//"⬛");
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
