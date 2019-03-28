using System;

namespace Ex10
{
    class Complex
    {
        int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Complex Add(Complex c)
        {
            Complex c1 = new Complex(this.a + c.a, this.b + c.b);
            return c1;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }

        public static Complex operator +(Complex n1, Complex n2)
        {
            Complex k = new Complex(n1.a + n2.a, n1.b + n2.b);
            return k;
        }

        //public static Complex operator +(Complex n1,int n2)
        //{
        //    Complex k = new Complex(n1.a + n2, n1.b + n2);
        //    return k;
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex n1 = new Complex(1, 2);
            Complex n2 = new Complex(2, 4);
            Complex sum1 = n1.Add(n2);
            Complex sum2 = n1 + n2; //заново написали плюс для двух эземпляров класса Complex
            Complex sum3 = n1 + n2+n1+n2;
            //Complex sum = n1 + 3; 
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}
