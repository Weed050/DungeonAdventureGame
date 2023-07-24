using DungeonAdventureGame.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Enemies
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {
        }
        private void Attack()
        {
            if (this.Nearby(game.PlayerLocation, 10))
            {
                game.HitPlayer(3, new Random());
            }
        }
        public override void Move(Random random)
        {
            if (HitPoints > 0)
            {

                int i = random.Next(3);

                switch (i)
                {
                    case 0:
                        base.Move((Direction)random.Next(0, 4), game.Boundaries);
                        break;
                    case 1:
                        base.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                        break;
                    case 2:
                        break;
                }
                Attack();
            }
        }
    }
}
