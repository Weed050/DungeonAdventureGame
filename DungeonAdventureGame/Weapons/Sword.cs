using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Weapons
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {

        }
        public override string Name { get => "Miecz"; }
        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, random, 3, 10))
            {
                int directionInt = (int)direction;
                if (directionInt <= 0)
                    directionInt += 4;
                direction = (Direction)directionInt--;
            }
            else if (!DamageEnemy(direction, random, 3, 10))
            {
                int directionInt = (int)direction;
                if (directionInt >= 3)
                    direction -= 4;
                direction = (Direction)directionInt + 2;
            }
            else
                DamageEnemy(direction, random, 3, 10);


        }
    }
}
