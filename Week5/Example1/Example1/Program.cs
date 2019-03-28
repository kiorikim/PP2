using System;
using System.IO;
namespace Example2
{
    class Program
    {
        public static void F1()
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/kimkiori/Desktop/university/PP2/PP2");
            FileSystemInfo[] fsi = dir.GetFileSystemInfos();
            foreach (FileSystemInfo fs in fsi)
            {
                if (fs.GetType() == typeof(FileInfo))
                {
                    Console.WriteLine(fs.Name);
                }
                else
                {
                    DirectoryInfo d1 = new DirectoryInfo(fs.FullName);
                    Console.WriteLine(fs.Name + " " + "(" + d1.GetFileSystemInfos().Length + ")");
                }
            }
        }
        public static void TxtCounter()
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/kimkiori/Desktop/university/PP2/PP2");
            FileInfo[] files = dir.GetFiles("*.txt");
            Console.WriteLine(files.Length);
        }
        public static bool IsPalindrome(string s)
        {
            int n = s.Length;
            for (int i = 0; i < n/2; i++)
            {
                if (s[i] != s[n - i - 1])
                    return false; 
            }
            return true;
        }

        static void Main(string[] args)
        {
            F1();
            TxtCounter();
            DirectoryInfo dir = new DirectoryInfo("/Users/kimkiori/Desktop/university/PP2/PP2");
            FileSystemInfo[] fsi = dir.GetFileSystemInfos();
            foreach (FileSystemInfo fs in fsi)
            {
                if (IsPalindrome(fs.Name))
                {
                    Console.WriteLine(fs.Name);
                }
            }
        }
    }
}