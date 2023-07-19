using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonAdventureGame.Enemies;
using DungeonAdventureGame.Players;
using DungeonAdventureGame.Weapons;

namespace DungeonAdventureGame
{
    class Game
    {
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }
        private Player player;
        public Point PlayerLocation { get => player.Location; }
        public int PlayerHitpoints { get => player.HitPoints; }
        public IEnumerable<string> PlayerWeapons { get => player.Weapons; }
        private int level = 0;
        public int Level { get => level; }
        private Rectangle boundaries;
        public Rectangle Boundaries { get => boundaries; }
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(
                this,
                new Point(boundaries.Left + 10, boundaries.Top + 70));
        }
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        public void Equip(string weaponName)
            => player.Equip(weaponName);

        public bool CheckPlayerInventory(string weaponName)
            => player.Weapons.Contains(weaponName);

        public void HitPlayer(int maxDamage, Random random)
            => player.Hit(maxDamage, random);

        public void IncreasePlayerHealth(int health, Random random)
            => player.IncreaseHealth(health, random);
        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }
        private Point getRandomLocation(Random random)
            => new Point(
                boundaries.Left +
                    random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top +
                    random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        public void NextLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies = Enemies.Concat(new[] { new Bat(this, getRandomLocation(random)) });
                    WeaponInRoom = new Sword(this, getRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemy>();
                    //Enemies.Concat(new Ghost(this,getRandomLocation(random)));
                    Enemies = Enemies.Concat(new[] { new Ghost(this, getRandomLocation(random)) });

                    if (!CheckPlayerInventory("BigMixture") && !CheckPlayerInventory("SmallMixture"))
                        WeaponInRoom = new SmallMixture(this, getRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>();
                    Enemies = Enemies.Concat(new[] { new Reaper(this, getRandomLocation(random)) });
                    WeaponInRoom = new Bow(this, getRandomLocation(random));
                    break;
                case 4:

                    Enemies = new List<Enemy>();
                    Enemies = Enemies.Concat(new[] { new Bat(this, getRandomLocation(random)) });
                    Enemies = Enemies.Concat(new[] { new Ghost(this, getRandomLocation(random)) });
                    if (!CheckPlayerInventory("Bow"))
                        WeaponInRoom = new Bow(this, getRandomLocation(random));
                    else if (!CheckPlayerInventory("BigMixture") && !CheckPlayerInventory("SmallMixture"))
                        WeaponInRoom = new SmallMixture(this, getRandomLocation(random));
                    break;
                case 5:

                    Enemies = new List<Enemy>();
                    Enemies = Enemies.Concat(new[] { new Bat(this, getRandomLocation(random)) });
                    Enemies = Enemies.Concat(new[] { new Reaper(this, getRandomLocation(random)) });

                    if (!CheckPlayerInventory("BigMixture") && !CheckPlayerInventory("SmallMixture"))
                        WeaponInRoom = new BigMixture(this, getRandomLocation(random));

                    break;
                case 6:

                    Enemies = new List<Enemy>();
                    Enemies = Enemies.Concat(new[] { new Ghost(this, getRandomLocation(random)) });
                    Enemies = Enemies.Concat(new[] { new Reaper(this, getRandomLocation(random)) });

                    WeaponInRoom = new Club(this, getRandomLocation(random));

                    break;

                case 7:

                    Enemies = new List<Enemy>();
                    Enemies = Enemies.Concat(new[] { new Bat(this, getRandomLocation(random)) });
                    Enemies = Enemies.Concat(new[] { new Ghost(this, getRandomLocation(random)) });
                    Enemies = Enemies.Concat(new[] { new Reaper(this, getRandomLocation(random)) });

                    if (!CheckPlayerInventory("Club"))
                        WeaponInRoom = new Club(this, getRandomLocation(random));
                    else if (!CheckPlayerInventory("BigMixture") && !CheckPlayerInventory("SmallMixture"))
                        WeaponInRoom = new BigMixture(this, getRandomLocation(random));

                    break;
                case 8:
                    Application.Exit();
                    break;
            }
        }
    }
    enum Direction
    {
        Up,
        Right,
        Down,
        Left,
    }
}
