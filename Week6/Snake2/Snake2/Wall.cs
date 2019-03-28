using System;
using System.IO;
using System.Collections.Generic;
namespace Snake2
{
    public class Wall:GameObject
    {
        public enum GameLevel
        {
            Fisrt,
            Second,
            Third
        }
        public GameLevel gamelevel = GameLevel.Fisrt;
        public Wall(char sign, ConsoleColor color):base(0,0,sign,color)
        {
            body = new List<Point>();
        }
        public void Level(string fileName)
        {
            if( gamelevel == GameLevel.Fisrt)
            {
                StreamReader sr = new StreamReader(fileName);
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    int y = 0;
                    for(int x=0;x<s.Length;x++)
                    {
                        if (s[x] == '*')
                            body.Add(new Point(x, y));
                        y++;
                    }
                }
            }
            if (gamelevel == GameLevel.Second)
            {

            }
            if (gamelevel == GameLevel.Third)
            {

            }
        }
        public void LoadLevel()
        {
            body = new List<Point>();
            if (gamelevel == GameLevel.Fisrt)
            {
                Level("Level1.txt");
            }
            if (gamelevel == GameLevel.Second)
            {
                Level("Level2.txt");
            }
            if (gamelevel == GameLevel.Third)
            {
                Level("Level3.txt");
            }
        }
            public void NextLevel()
        {
            if (gamelevel == GameLevel.Fisrt)
            {
                gamelevel = GameLevel.Second;
            }
            else if (gamelevel == GameLevel.Second)
            {
                gamelevel = GameLevel.Third;
            }
            LoadLevel();

        }
    }
}
