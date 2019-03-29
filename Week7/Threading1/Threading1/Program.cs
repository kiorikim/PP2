using System;
using System.Threading;

namespace Threading1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[11];
            for (int i = 1; i <= 10; i++)
            {
                threads[i] = new Thread(PrintV);
                threads[i].Name = i.ToString();
                threads[i].Start();
            }
        }

        static void PrintV()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write(Thread.CurrentThread.Name + " 0 ");
        }
    }
}
