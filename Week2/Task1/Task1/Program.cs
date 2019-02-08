using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Task1()
        {
            StreamReader sr = new StreamReader("input.txt");
            String s = sr.ReadToEnd();
            int n = 0;
            for(int i=0;i<s.Length/2;i++)
            {
                if (s[i] == s[s.Length - i-1])
                    n++;
                else
                    break;
            }
            if (n == s.Length / 2)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
        static void Main(string[] args)
        {
            Task1();
        }
    }
}
