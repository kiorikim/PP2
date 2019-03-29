using System;
using System.Threading;
namespace Moving
{
    class Program
    {
        static Point p;
        static void Main(string[] args)
        {
            p = new Point(10, 10);
            Thread THREAD = new Thread(Square);
            THREAD.Start();
        }
        static void Square()
        {
            while (true)
            {
                p.ChangeDirection();
                p.Draw();
                Thread.Sleep(1000);
            }
        }

    }
}
