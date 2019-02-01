using System;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int yostudy;
        public Student(string name, string id, int yostudy)
        {
            this.name = name;
            this.id = id;
            this.yostudy = yostudy;
        }
        public void PrintStudent()
        {
            for (int i = 1; i < 5; i++)
            {
                this.yostudy = i;
                Console.WriteLine(this);
            }
        }
        public override string ToString()
        {
                return name + " " + id + " " + yostudy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student("Kiori", "18BD123455", 1);
            first.PrintStudent();
        }
    }
}
