using System;
namespace Serialization2
{
    public class Mark
    {
        public int points;
        public string letter;
        public Mark() { }
        public Mark(int points)
        {
            this.points = points;
            this.letter = GetLetter(points);
        }
        public string GetLetter(int points)
        {
            if (points >= 95 && points <= 100)
                return "A";
            if (points >= 90 && points < 95)
                return "A-";
            if (points >= 85 && points < 90)
                return "B+";
            if (points >= 75 && points < 95)
                return "B";
            else
                return "F";
        }
        public override string ToString()
        {
            return points + " " + letter;
        }
    }

}
