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
        public Point Location { get => location; }
        private Point location;
        public bool PickedUp { get; set; }
        

       
        public void DamageEnemy()
        {

        }
        public void PickUpWeapon()
        {

        }
    }
}
