using System;
using System.IO;
using System.Xml.Serialization;
namespace Serialization3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe e1 = new Employe();
            e1.Name = "AAAA";
            e1.Id = 1;
            e1.Salary = 50000;
            e1.Increase(e1.Salary);
            e1.Increase(e1.Salary);
            Ser(e1);
            Des();
        }
        static void Ser(Employe e1)
        {
            FileStream fs = new FileStream("employe.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employe));
            xs.Serialize(fs, e1);
            fs.Close();
        }
        static void Des()
        {
            FileStream fs = new FileStream("employe.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employe));
            Employe e1des = xs.Deserialize(fs) as Employe;
            fs.Close();
            Console.WriteLine(e1des);
        }
    }

}
