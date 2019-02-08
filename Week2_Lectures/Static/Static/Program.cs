using System;

namespace Static
{
    class Test
    {
        public static int a; //общая для экземпляров С и Д (instances)
        public int b; //разный для экземпляров С и Д (instances)
        public void IncA()
        {
            a++; 
        }
        public void IncB()
        {
            b++;
        }
        public void Print()
        {
            Console.WriteLine(a + " " + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test i1 = new Test();
            Test i2 = new Test();
            i1.IncA(); //a=1
            i2.IncA(); //a=2
            i1.IncB(); //b in i1 = 1
            i1.IncB(); //b in i1 = 2
            i1.IncB(); //b in i1 = 3
            i2.IncB(); //b in i2 = 1

            i1.Print();
            i2.Print();
        }
    }
}
