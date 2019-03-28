using System;
namespace Threading3
{
    public class Snake
    {
        public int x, y;
        enum Direction
        { 
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        Direction direction;
        public Snake(int x, int y)
        {
            this.x = x;
            this.y = y;
            direction = Direction.UP;
        }
        public void Move(ConsoleKeyInfo keyInfo)
        { 
            if(keyInfo.Key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            if (keyInfo.Key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            if (keyInfo.Key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            if (keyInfo.Key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
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
                y++;
            Console.Clear();
            Console.CursorVisible = true;
            Console.SetCursorPosition(x, y);
            Console.Write("*"); 

        }
    }
}
