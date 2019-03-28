using System;
using System.Threading;
namespace Threading2
{
    class Program
    {
        public static Object lockObject = new object();
        static int k = 100;
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            for(int i=0; i<10; i++)
            {
                threads[i] = new Thread(PrintV);
                threads[i].Start();
            }
        }
        static void PrintV()
        {
            lock(lockObject)
            {
                Console.WriteLine(k);
                k -= 10;
            }
        }
    }
}
