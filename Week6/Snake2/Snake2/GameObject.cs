using System;
using System.Collections.Generic;
namespace Snake2
{
    public class GameObject
    {
        public List<Point> body;
        public char sign;
        ConsoleColor color;
        public GameObject(int x, int y, char sign, ConsoleColor color)
        {
            body = new List<Point>();
            body.Add(new Point(x,y));
            this.sign = sign;
            this.color = color;
        }
        public void Draw()
        {
            foreach(Point p in body)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }

        }
        //public bool isCollision(GameObject go)
        //{
        //    for (int i=0;i<go.body.Count;i++)
        //    {
        //        if (go.GetType() == typeof(Snake) && i == 0)
        //            continue;
        //        if (this.body[0].x == go.body[i].x && this.body[0].y == go.body[i].y)
        //            return true;
        //    }
        //}
    }
}
