using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Weapons
{
    class Bow : Weapon
    {
        public Bow(Game game,Point location):base(game,location)
        {
            
        }
        public override string Name { get => "Łuk"; }

    }
}
