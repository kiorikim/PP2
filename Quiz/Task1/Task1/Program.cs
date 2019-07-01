using System;
using System.IO;
using System.Xml.Serialization;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop sh = new Shop("aa", "bb");
            Ser(sh);
            Deserer(sh);
        }
        public static void Ser(Shop sh)
        {
            FileStream fs = new FileStream("shop.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Shop));
            xs.Serialize(fs, sh);
            fs.Close();
        }
        public static void Deserer(Shop sh)
        {
            FileStream fs = new FileStream("shop.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Shop));
            Shop newSh = xs.Deserialize(fs) as Shop;
            Console.WriteLine(newSh);
            fs.Close();
        }
    }
   
}
