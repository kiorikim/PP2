using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "/Users/kimkiori/Desktop/university/PP2/PP2/Week2/Task3";
            string path2 = "/Users/kimkiori/Desktop/university/PP2/PP2/Week2/Task4";
            string firstFile = Path.Combine(path1, "newFile.txt");
            string copyOfFile = Path.Combine(path2, "newFile.txt");

            //same as combine
            //string firstFile = "/Users/kimkiori/Desktop/university/PP2/PP2/Week2/Task3/newFile.txt";
            //string copyOfFile = "/Users/kimkiori/Desktop/university/PP2/PP2/Week2/Task4/newFile.txt";

            FileStream fs = File.Create(firstFile);
            fs.Close();
            File.Copy(firstFile,copyOfFile,true);
            File.Delete(firstFile);
        }
    }
}
