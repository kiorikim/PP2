using System;

namespace Task3
{
    class Program
    {
        static int[]  CreateNew (int a,int n)
        {
            int[] b = new int[n*2];
            for (int i = 0; i < n*2; i+=2) //outputting each element in array of nukmber two times
            {
                b[i] = a;
                b[i + 1] = a;
            }
                return b;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //input the size of array
            string[] s = Console.ReadLine().Split(); //input the array in string and spliting it by " "
            int[] a = new int[n]; //creating an array of numbers
            for(int i=0;i<n; i++) //parsing a array of strings to array of numbers
            {
                a[i] = int.Parse(s[i]);
                CreateNew(a[i], n);
            }
        }
    }
}
