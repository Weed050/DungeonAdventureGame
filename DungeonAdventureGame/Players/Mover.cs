using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Players
{
    abstract class Mover
    {
        protected Game game;
        private const int MoveInterval = 10;
        public Point Location { get => location; }

        protected Point location;

        public Mover(Game game,Point point)
        {
            location = point;
           this.game = game;
        }

        public bool Nearby(Point locationToCheck, int distanse)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distanse
                && Math.Abs(location.Y- locationToCheck.Y) < distanse)
                return true;
            else
                return false;
        }

        public virtual Point Move(Direction direction, Rectangle boudaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boudaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval >= boudaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boudaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval >= boudaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                    default: break;
            }
            return newLocation;
        }
    }
}
