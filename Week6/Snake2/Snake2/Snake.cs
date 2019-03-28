using System;
using System.Collections.Generic;
namespace Snake2
{
    public class Snake:GameObject
    {
        public enum Direction
        { 
            UP,
            DOWN,
            LEFT, 
            RIGHT
        }
        public Direction direction;
        public Snake(int x, int y, char sign, ConsoleColor color):base(x,y,sign,color)
        {
            direction = Direction.DOWN;
        }
        public void Move()
        {
            for(int i=body.Count-1;i>0;i--)
        {
            body[i].x = body[i - 1].x;
            body[i].y = body[i - 1].y;
        }
        if (direction == Direction.DOWN)
            body[0].y++;
        if (direction == Direction.UP)
            body[0].y--;
        if (direction == Direction.LEFT)
            body[0].x--;
        if (direction == Direction.RIGHT)
            body[0].x++;
    }
        public void ChangeDirection()
        {
            while(true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = Direction.UP;
                else if(keyInfo.Key == ConsoleKey.DownArrow)
                    direction = Direction.DOWN;
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = Direction.LEFT;
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = Direction.RIGHT;


            }
        }
        public bool isCollisionWithFood(Food food)
        {
            if (body[0].x == food.body[0].x && body[0].y == food.body[0].y)
                return true;
            return false;
        }
        public bool isCollisionWithWall(Wall wall)
        {
            foreach(Point p in wall.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            }
            return false;
        }

    }
}
