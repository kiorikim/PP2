using System;
namespace Threading2
{
    public class Bank
    {
        public int balance;
        public Bank (int balance)
        {
            this.balance = balance;
        }
        public void Add(int x)
        {
            balance = balance + x;
        }
        public void Delete(int x)
        {
            balance = balance - x;
        }
    }
}
