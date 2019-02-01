using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] a = new string[n+1,n+1];
            for(int i=1;i<=n;i++)
            { 
                for(int j=1;j<=i;j++)
                {
                    a[i, j] = "[*]";
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
