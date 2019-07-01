using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Task1
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    public class Snake
    {
        public string BodyColor;
        public List<Point> body = new List<Point>();
        public Snake(string BodyColor)
        {
            this.BodyColor = BodyColor;
            this.body = body;
        }
        public Snake() { }
        public void Draw()
        {
            for (int i = 0; i < body.Count; i++)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write("*");
            }
        }
    }
    class Program
    { 
    static void Main(string[] args)
        {
            F2();
        }
        public static void F2()
        {
            FileStream fs = new FileStream("Snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            Snake Snake = xs.Deserialize(fs) as Snake;
            fs.Close();
            Snake.Draw();
        }
    }
}
