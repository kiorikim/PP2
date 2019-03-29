using System;
namespace Moving
{
    public class Point
    {
        public int x;
        public int y;
        public int sx;
        public int sy;
        enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        Direction direction;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.direction = Direction.RIGHT;
        }
        public void Draw()
        {
            if (direction == Direction.UP)
                y--;
            if (direction == Direction.DOWN)
                y++;
            if (direction == Direction.LEFT)
                x--;
            if (direction == Direction.RIGHT)
                x++;
            Console.Clear();
            Console.CursorVisible = true;
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
        public void ChangeDirection()
        {
            if(x == 20 && direction == Direction.RIGHT)
                direction = Direction.DOWN;
            if (y == 20 && direction == Direction.DOWN)
                direction = Direction.LEFT;
            if (x == 10 && direction == Direction.LEFT)
                direction = Direction.UP;
            if (y == 10 && direction == Direction.UP)
                direction = Direction.RIGHT;
        }
    }
}
