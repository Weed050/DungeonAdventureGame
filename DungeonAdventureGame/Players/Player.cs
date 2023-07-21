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
        private Weapon equipedWeapon;
        public int HitPoints { get; private set; }
        private IEnumerable<Weapon> inventory = new List<Weapon>();

        public IEnumerable<string> Weapons {
            get {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        public Player(Game game, Point point) : base(game, point) 
            => HitPoints = 10;

        public void IncreaseHelth(int health, Random random) 
            => HitPoints += random.Next(1, health);

        public void Hit(int maxDMG,Random random) 
            => HitPoints -= random.Next(1,maxDMG);

        public void Equip(string weaponName)
        {
            foreach (var weapon in inventory)
                if (weapon.Name == weaponName)
                            equipedWeapon = weapon;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction,game.Boundaries);

            if (!game.WeaponInRoom.PickedUp)
                if (game.WeaponInRoom.Location == this.location || this.Nearby(game.WeaponInRoom.Location,this.Location ) /// do poprawy
                    Equip(game.WeaponInRoom.Name);
        }
    }
}
