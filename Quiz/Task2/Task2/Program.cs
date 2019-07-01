using System;
using System.Threading;
namespace Task2
{
    class Program
    {
        static Point p;
        static void Main(string[] args)
        {
            p = new Point(10, 10);
            Thread move = new Thread(Move);
            move.Start();
        }
        static void Move()
        {
            while(true)
            {
                p.Draw();
                Thread.Sleep(1000);
            }
        }
    }
}
