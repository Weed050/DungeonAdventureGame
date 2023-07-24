using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Players
{
    abstract class Enemy : Mover
    {
        private const int NearPLayerDistance = 25;
        public int HitPoints { get; private set; }
        public bool Dead
        {
            get
            {
                if (HitPoints <= 0) return true;
                else return false;
            }
        }
        public Enemy(Game game, Point point, int hitPoints) : base(game, point)
            => this.HitPoints = hitPoints;

        public void Hit(int maxDMG, Random random)
           => HitPoints -= random.Next(1, maxDMG);

        protected bool NearPlayer()
            => (Nearby(game.PlayerLocation, NearPLayerDistance));

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Down;
            else
                directionToMove = Direction.Up;
            return directionToMove;
        }
        public abstract void Move(Random random);
    }
}

