using DungeonAdventureGame.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Weapons
{
    abstract class Weapon : Mover
    {
        public abstract string Name { get; }
        public int maxDmg; // tymczasowe
        public bool PickedUp { get; private set; }
        public void PickUpWeapon()
            => PickedUp = true;

        public abstract void Attack(Direction direction,Random random);
        public Weapon(Game game,Point location):base(game, location)
        {
            PickedUp = false;
        }

        protected bool DamageEnemy(Direction direction,Random random,int damage,int radius)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location,target,distance))
                    {
                        enemy.Hit(damage,random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

    }
}
