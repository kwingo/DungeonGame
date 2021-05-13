using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pair_Programming.Attack;

namespace Pair_Programming
{
    public interface IBoss
    {
        int Health { get; }
        void Scream();
        void Hurt(int damage);
        int Attack(Attack attack);
        Attack attack();
    }
    public class SubBoss : DungeonGame
    {
        private string Slashing;

        public int Health { get; set; } = 100;
        public void Scream()
        {
            Console.WriteLine("YOU DO NOT BELONG HERE. GET OUT!");
        }

        public void Hurt(Attack attack)
        {
            Health -= attack.Damage;
        }

        public Attack Enemy()
        {
            return new Attack(5, 10, DamageType.Slashing, "Flash Attack");
        }

        public Attack ShockAttack()
        {
            return new Attack(8, 10 ,DamageType.Shocking, "Shock of Death");
        }

        public Attack FireAttack()
        {
            return new Attack(9, 10, DamageType.Fire, "Light up your life");
        }

        public Attack SaberAttack()
        {
            return new Attack(1, 10, DamageType.Sword, "Sword attack");
        }

        public Attack RustySwordAttack()
        {
            return new Attack(1, 10, DamageType.Sword, "Rusty Sword Attack");
        }

        public Attack BludgeonAttack()
        {
            return new Attack(1, 10, DamageType.Bludgeoning, "Bludgeon Attack");
        }

        public Attack PoisonDaggerAttack()
        {
            return new Attack(1, 10, DamageType.Poison, "Poison Dagger Attack");
        }

        public Attack PierceYourEnemy()
        {
            return new Attack(1, 10, DamageType.Piercing, "Piercing Dagger Attack");
        }

        public Attack CryokineticSlay()
        {
            return new Attack(1, 10, DamageType.Ice, "Cryokinetic Blade Attack");
        }

        public Attack PyrokineticSlay()
        {
            return new Attack(1, 10, DamageType.Fire, "Pyrokinetic Blade Attack");
        }

        public Attack MagicSwordAttack()
        {
            return new Attack(1, 10, DamageType.Magic, "Magic Sword Attack");
        }

        public Attack HyrdokineticSlay()
        {
            return new Attack(1, 10, DamageType.Water, "Pyrokinetic Whip Attack");
        }

        public Attack ElectromagneticShock()
        {
            return new Attack(1, 10, DamageType.Shocking, "Electromagnetic Attack");
        }
    }
}
