using System;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {            
            int n = int.Parse(Console.ReadLine()); //input the size of a set
            string[] s = Console.ReadLine().Split(); //reading the set as a string anf dividing it by " " character
            int[] a = new int[n]; //initializing an array for input set
            List<int> list = new List<int>(); //initializing list to keep prime numbers
            for (int i = 0; i < n; i++) //running through all numbers
            {
                bool isPrime = true; //initializing bool to check whether number is prime or not
                a[i] = int.Parse(s[i]); //converting number from string to int and putting it into array
                int x = (int)(Math.Sqrt(a[i])); //taking square root of number using Math
                for (int j = 2; j <= x; j++) //checking whether number is prime
                {
                    if (a[i] % j == 0)
                        isPrime = false; //if number divides on some other number without the remainder it is not prime
                }
                if (isPrime && a[i] != 1) //one is not prime
                {
                    list.Add(a[i]); //adding number to the list of answers if it is prime
                }
            }
            Console.WriteLine(list.Count); //output how many prime number there were in a set
            for (int i = 0; i < list.Count; i++) //outp
            {
                Console.Write(list[i] + " "); //output all prime numbers
            }
        }
    }
}
