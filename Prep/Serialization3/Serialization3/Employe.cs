using System;
namespace Serialization3
{
    public class Employe
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        private int id;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        private int salary;
        public int Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }
        public void Increase(int salary)
        {
            this.salary = this.salary + 50000;
        }
        public override string ToString()
        {
            return name + " " + id + " " + salary;
        }
        public Employe()
        {

        }

    }
}
