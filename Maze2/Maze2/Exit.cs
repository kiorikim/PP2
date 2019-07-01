using System;
namespace Maze2
{
    public class Exit : GameObject
    {
        public Exit(char label) : base(label) { }

        public Point getPosition()
        {
            return locations[0];
        }

    }
}
