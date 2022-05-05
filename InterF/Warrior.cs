using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterF
{
        interface iWeapon
        {
            string Kill();
        }
        class Sword : iWeapon
        {
            public string Kill()
            {
                return $" вооружен мечом";
            }
        }
        class Bazooka : iWeapon
        {
            public string Kill()
            {
                return $" вооружен базукой";
            }
        }
        class GenerateGun
        {
            iWeapon[] weapon = { new Sword(), new Bazooka() };
            public iWeapon GiveGun()
            {
                Random rnd = new Random();
                return weapon[rnd.Next(weapon.Length)];
            }
        }
        class Warrior : GenerateGun
        {
            public string Name { get; set; }
            public iWeapon gun { get; set; }
            public Warrior()
            {
                gun = base.GiveGun();
            }
            public override string ToString()
            {

                return $"Крестьянин {Name}{gun.Kill()}";
            }
        }
}