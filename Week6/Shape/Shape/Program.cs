using System;
using System.Collections.Generic;
namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Rectangle rectangle = new Rectangle(4, 5);
            Circle circle = new Circle(1,2,3);
            Shape.Add(rectangle);
            Shape.Add(circle);
            foreach(Shape shape in shapes)
            {
                if(shape.GetType() == typeof(Circle))
                {
                    Console.WriteLine(((Circle).shape).x + " ");
                }
            }
        }
    }
}
