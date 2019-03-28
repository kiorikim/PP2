using System;
using System.IO;
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            //Console.SetWindowSize(35, 35);
            //Console.SetBufferSize(35, 35);
            //Console.SetCursorPosition(10,10);
            //Console.CursorVisible = true;
            //Console.WriteLine("000");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            int x = 10, y = 10;
            while( keyInfo.Key != ConsoleKey.Escape)
            { 
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    y++; 
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    y++;
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                }
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.CursorVisible = true;
                Console.Write("*");
                Console.ReadKey();
            }
        }
    }
}
