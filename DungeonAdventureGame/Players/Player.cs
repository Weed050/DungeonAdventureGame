using DungeonAdventureGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonAdventureGame.Players
{
    class Player : Mover
    {
        private Weapon equipedWeapon;
        public int HitPoints { get; private set; }
        private IEnumerable<Weapon> inventory = new List<Weapon>();

        public IEnumerable<string> Weapons
        {
            get
            {
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

        public void Hit(int maxDMG, Random random)
            => HitPoints -= random.Next(1, maxDMG);

        public void Equip(string weaponName)
        {
            foreach (var weapon in inventory)
                if (weapon.Name == weaponName)
                    equipedWeapon = weapon;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);

            if (!game.WeaponInRoom.PickedUp)
                if (game.WeaponInRoom.Location == this.location || this.Nearby(game.WeaponInRoom.Location, 1)
                        Equip(game.WeaponInRoom.Name);
        }
        public void Attack(Direction direction, Random random)
        {
            if (!(equipedWeapon == null))
            {
                if (equipedWeapon is IPotion)
                {
                    // leczenie (zostawiam do zrobienia, bo nie wiem jak działają potiony)
                    equipedWeapon = null;
                }
                else
                {
                    foreach (var enemy in game.Enemies)
                    {
                        if ((direction == Direction.Up) && (this.location.Y < enemy.Location.Y) && ((this.location.Y - enemy.Location.Y) <= 1))
                            enemy.Hit(equipedWeapon.maxDmg, random);

                    }
                    

                }
            }
        }
    }
}
