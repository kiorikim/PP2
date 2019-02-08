using System;
using System.IO;

namespace Task2
{
    class Program
    {

        static void writeAnswer(int a)
        {

           
        }
        static void Task2 ()
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            String[] s = sr.ReadToEnd().Split(" ");
            int[] a = new int[s.Length - 1];
            for(int i=0;i<s.Length-1;i++)
            {
                bool isPrime = true;
                a[i] = int.Parse(s[i]);
                int x = (int)(Math.Sqrt(a[i])); 
                for (int j = 2; j <= x; j++) 
                {
                    if (a[i] % j == 0)
                        isPrime = false; 
                }
                if (isPrime && a[i] != 1)
                {
                    sw.Write(a[i] + " ");
                }
            }
            sr.Close();
            sw.Close();
        }
        static void Main(string[] args)
        {
            Task2();
        }
    }
}
