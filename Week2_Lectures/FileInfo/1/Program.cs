using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void ex1()
        {
            FileInfo fileInfo = new FileInfo("/Users/kimkiori/Desktop/for\\ kids/abcd.jpg");
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Directory);
        }

        static void ex2()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("/Users/kimkiori/Desktop/for\\ kids/abcd.jpg");
            Console.WriteLine(directoryInfo.Name);
            Console.WriteLine(directoryInfo.FullName);
            Console.WriteLine(directoryInfo.Parent); //папка до
        }

        static void ex3()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("/Users/kimkiori/Desktop/ottoke_taks");
            FileInfo[] files = directoryInfo.GetFiles(); //все файлы в директории
            foreach(FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            DirectoryInfo[] directories = directoryInfo.GetDirectories(); //все папки в директории
            foreach (DirectoryInfo directory in directories)
            {
                Console.WriteLine(directory.Name);
            }
        }


        static void PrintSpaces(int level)
        {
            for(int i=0;i<level;i++)
            {
                Console.Write("_ "); 
            }
        }
        static void ex4(DirectoryInfo directory, int level)
        {
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (DirectoryInfo dir in directories)
            {
                PrintSpaces(level);
                Console.WriteLine(dir.Name);
                ex4(dir, level + 1);
            }
        }

        static void ex5()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("/Users/kimkiori/Desktop/ottoke_taks");
            FileSystemInfo[] fs = directoryInfo.GetFileSystemInfos();
            foreach(FileSystemInfo f in fs)
            {
                if(f.GetType() == typeof(DirectoryInfo))
                {
                    Console.WriteLine("DERCTORY:" + f.Name);
                }
                else
                {
                    Console.WriteLine(f.Name);
                }
            }
        }


        static void ex6()
        {
            StreamReader sr = new StreamReader("input.txt");
            //String s = sr.ReadLine(); //только одна строка
            String s1 = sr.ReadToEnd(); //все строки
            Console.WriteLine(s1);
            sr.Close();
        }

        static void ex7()
        {
            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine("hello");
            sw.WriteLine("hello2");
            sw.Close();
        }

        static void ex8()
        {

            ConsoleKeyInfo ck = Console.ReadKey();
            while(ck.Key!=ConsoleKey.Escape)
            {
                if (ck.Key == ConsoleKey.UpArrow)
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Up");
                }

                if (ck.Key == ConsoleKey.DownArrow)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Down");
                }

                ck = Console.ReadKey();

            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("/Users/kimkiori/Desktop/ottoke_taks");
            ex8();
        }
    }
}
