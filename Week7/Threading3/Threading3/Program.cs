using System;
using System.Threading;
namespace Threading3
{
    class Program
    {
        static Snake snake;
        static void Main(string[] args)
        {
            snake = new Snake(10, 10);
            Thread THREAD = new Thread(Move);
            while(true)
            {
                snake.Draw();
                Thread.Sleep(1000);
            }
        }
        static void Move()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                snake.Move(keyInfo);
            }
        }
    }
}
