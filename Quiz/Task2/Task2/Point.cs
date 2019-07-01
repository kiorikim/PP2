using System;
namespace Task2
{
    public class Point
    {
        public int x;
        public int y;
        public int counter=0;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
            if (x<=20)
                x++;
            else
            {
                while(x!=10)
                x--;
            }
            Console.Clear();
            Console.CursorVisible = true;
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
    }
}
