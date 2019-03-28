using System;
using System.IO;


namespace Lecture //homework - открыть и отрелактировать файл, создать удалить переместить
{
    class FarManager
    {

        public int cursor;
        public int sz;
        bool ok;

        public FarManager()
        {
            cursor = 0;
            ok = true;
        }

        public void Up()
        {
            cursor--;
            if (cursor < 0)
            {
                cursor = sz - 1;
            }
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
            {
                cursor = 0;
            }
        }

        public void Color(FileSystemInfo fs, int index)
        {
            if (index == cursor)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] fileSystemInfos = directory.GetFileSystemInfos();
            sz = fileSystemInfos.Length;
            int index = 0;
            foreach (FileSystemInfo fs in fileSystemInfos)
            {
                if (ok && fs.Name.StartsWith("."))
                {
                    sz--;
                    continue;
                }
                this.Color(fs, index);

                Console.WriteLine(fs.Name);
                index++;
            }
        }
        public void Start(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            FileSystemInfo fs = null;
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path); //передавать начальный и конечный элемент чтобы показывать ограниченнное количество файлов на экране
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.Escape)
                {
                    cursor = 0;
                    directory = directory.Parent;
                    path = directory.FullName;
                }

                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow)
                    ok = false;
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                    ok = true;
                if (consoleKey.Key == ConsoleKey.O)
                {
                    StreamReader st = new StreamReader(directory.GetFileSystemInfos()[cursor].FullName);
                    Console.Clear();
                    Console.WriteLine(st.ReadToEnd());
                    st.Close();
                    consoleKey = Console.ReadKey();
                }
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    //Console.WriteLine(directory.GetFileSystemInfos()[cursor].GetType());
                    for (int i = 0, k = 0; i < directory.GetFileSystemInfos().Length; i++)
                    {
                        if (ok && directory.GetFileSystemInfos()[i].Name.StartsWith("."))
                            continue;
                        if (cursor == k)
                            fs = directory.GetFileSystemInfos()[i];
                        k++;
                    }
                    if (fs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        directory = new DirectoryInfo(fs.FullName);
                        path = fs.FullName;
                    }
                }
                if (consoleKey.Key == ConsoleKey.D)
                {
                    Console.Write(directory.GetFileSystemInfos()[cursor].GetType());
                    if (directory.GetFileSystemInfos()[cursor].GetType() == typeof(FileInfo))
                    {
                        FileInfo fi = new FileInfo(directory.GetFileSystemInfos()[cursor].FullName);
                        fi.Delete();
                        Show(path);
                    }
                    else
                    {
                        Directory.Delete(directory.GetFileSystemInfos()[cursor].FullName);
                    }

                }
                if (consoleKey.Key == ConsoleKey.R)
                {
                    string renamedFile = Path.Combine(path, Console.ReadLine());
                    File.Move(directory.GetFileSystemInfos()[cursor].FullName, renamedFile);
                }

            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            FarManager fm = new FarManager();
            fm.Start("/Users/kimkiori/Desktop/university/PP2/PP2");
            //fm.Start("/Users/kimkiori/Documents/ProjectE");
        }
    }
}
