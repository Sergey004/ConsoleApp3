using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Monster
    {
        public Monster()
        {
            this.health = 100;
            this.ammo = 100;
            this.name = "NoName";

        }
        public Monster(string name) : this()
        {
            this.name = name;
        }
        public Monster(int health, int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }
        public int Health  //свойство Health связфнно с полем health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 0) health = value;
                else health = 0;
            }
        }
        public int Ammo  //свойство Ammo связфнно с полем ammo 
        {
            get
            {
                return ammo;
            }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }
        }
        public string Name //свойство Name связфнно с полем name 
        {
            get
            {
                return name;
            }
        }
        public void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}",
                name, health, ammo);
        }
        string name; //закрытые поля
        int health, ammo;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Monster Masha = new Monster(200, 200, "Masha");
            Masha.Passport();
            --Masha.Health;
            Masha.Ammo += 100; //использования свойств
            Masha.Passport(); //использования свойств
            Console.Read();
        }
    }
}
