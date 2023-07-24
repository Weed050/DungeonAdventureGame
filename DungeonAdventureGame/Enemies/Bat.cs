using DungeonAdventureGame.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Enemies
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        { }

        bool halfChance = false;
        private void Attack()
        {
            if (this.Nearby(game.PlayerLocation, 10))
            {
                game.HitPlayer(2, new Random());
            }
        }
        public override void Move(Random random)
        {
            if (HitPoints > 0)
            {

                if (HitPoints > 2)
                {
                    if (halfChance)
                    {
                        base.Move((Direction)random.Next(0, 4), game.Boundaries);
                        halfChance = false;
                    }
                    else
                    {
                        base.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                        halfChance = true;
                    }
                }
                else
                    base.Move((Direction)random.Next(0, 4), game.Boundaries);
                Attack();
            }
        }
    }
}
