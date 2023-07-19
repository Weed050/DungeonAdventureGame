using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Players
{
    abstract class Enemy:Mover
    {
        public Enemy() 
        {
            
        }
        public int HitPoints;
    }
}
