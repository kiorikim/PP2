using System;
using System.Collections.Generic;
using System.Threading;
namespace Snake2
{
    public class Game
    {
        public Snake snake;
        public Food food;
        public Wall wall;
        public bool IsAlive;
        public int speed;
        List<GameObject> g_objects;
        public Game()
        {
            speed = 500;
            IsAlive = true;
            snake = new Snake(10, 10, '*', ConsoleColor.Blue);
            food = new Food(0, 0, '0', ConsoleColor.Red);
            wall = new Wall('#', ConsoleColor.Yellow);
            wall.LoadLevel();
            food.Generate(snake, wall);
            g_objects = new List<GameObject>();
            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);
            Console.CursorVisible = false;
        }
        public void Start()
        {
            //int k = 0;
            Thread thread = new Thread(snake.ChangeDirection);
            thread.Start();
            while( IsAlive)
            {
                snake.Move();
                Draw();
                Thread.Sleep(speed);
                if (snake.isCollisionWithFood(food))
                {
                    snake.body.Add(new Point(0, 0));
                    food.Generate(snake, wall);
                    if (snake.body.Count % 5 == 0)
                    {
                        wall.NextLevel();
                        speed = Math.Max(0, speed - 200); 
                    }
                }
                if (snake.isCollisionWithWall(wall))
                {
                    IsAlive = false;
                    Console.SetCursorPosition(10, 10);
                    Console.Write("Game over");
                }

            }
        }
        public void Draw()
        {
            Console.Clear();
            foreach(GameObject g in g_objects)
            {
                g.Draw();
            }
            //Console.SetCursorPosition(10, 10);
            //Console.Write("Size" + snake.body.Count);
        }
    }
}
