using DungeonAdventureGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Players
{
    class Player:Mover
    {
        public IEnumerable<Weapon> Weapons;
        public int HitPoints;
        public void Attack(Direction direction,Random random)
        {

        }
        public void Hit(int maxDMG,Random random) 
        {

        }
        public void Equip(string weaponName)
        {

        
        }
        public override Point Move(Direction direction) 
        {
        
        }
    }
}
