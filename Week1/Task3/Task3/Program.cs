using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //input the size of array
            string[] s = Console.ReadLine().Split(); //input the array in string and spliting it by " "
            int[] a = new int[n]; //creating an array of numbers
            for(int i=0;i<n; i++) //parsing a array of strings to array of numbers
            {
                a[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++) //outputting each element in array of nukmber two times
            {
                Console.Write(a[i] + " " + a[i] + " ");
            }
        }
    }
}
