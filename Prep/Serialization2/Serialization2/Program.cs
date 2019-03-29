using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace Serialization2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Mark> marks = new List<Mark>();
            Mark m1 = new Mark(95);
            marks.Add(m1);
            Mark m2 = new Mark(90);
            marks.Add(m2);
            Mark m3 = new Mark(35);
            marks.Add(m3);
            Serialization(marks);
            Deser(marks);
        }
        public static void Serialization(List<Mark> marks)
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            xs.Serialize(fs, marks);
            fs.Close();
        }
        public static void Deser(List<Mark> marks)
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            List<Mark> d = (List<Mark>)xs.Deserialize(fs);
            foreach (var x in d)
            {
                Console.WriteLine(x);
            }
            fs.Close();
        }
    }

}
