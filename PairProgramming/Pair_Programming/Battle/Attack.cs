using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming
{
    public class Attack
    {
        public enum DamageType { Bludgeoning, Slashing, Sword, Piercing, Poison, Fire, Water, Ice, Shocking, Magic};
        public int Damage;
        public DamageType type;

        public Attack(int damage, DamageType type)
        {
            Type = type;
            Damage = damage;
        }

        public DamageType Type;
        public string Name { get; set; }

        public Attack(int damage, DamageType type, string name)
        {
            Type = type;
            Damage = damage;
            Name = name;
        }

        public string Names { get; set; }
        private readonly Random rand = new Random();

        public Attack(int minDamage, int maxDamage, DamageType type, string Name)
        {
            Type = type;
            Damage = rand.Next(minDamage, maxDamage + 1);
        }
    }
}
