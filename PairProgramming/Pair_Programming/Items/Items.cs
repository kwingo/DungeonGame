using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming.Items
{
    public class Key : IItems
    {
        public string ItemName => "Key";

        public string ItemDescription => "This should open a door somewhere";
    }

    public class Cup : IItems
    {
        public string ItemName => "Cup";

        public string ItemDescription => "Seems like an ordinary cup";
    }

    public class LightSaber : IItems
    {
        public string ItemName => "Light Saber";
        public string ItemDescription => "You might want to get this weapon.";
    }

    public class RustySword : IItems
    {
        public string ItemName => "Rusty Sword ";
        public string ItemDescription => "Great choice.";
    }
    public class Bludgeon : IItems
    {
        public string ItemName => "Bludgeon";
        public string ItemDescription => "You can bludgeon the @^*! out of someone with this weapon.";
    }

    public class Poison : IItems
    {
        public string ItemName => "Poison Dagger";
        public string ItemDescription => "You gain a +1 bonus to attack and damage made with this weapon.";
    }

    public class Piercing : IItems
    {
        public string ItemName => "Piercing dagger";
        public string ItemDescription => "This weapon deals damage by force applied at a point. You might want to consider this weapon.";
    }

    public class Ice : IItems
    {
        public string ItemName => "Cryokinetic Blade";
        public string ItemDescription => "Construct bladed weapons out of ice.";
    }

    public class Fire : IItems
    {
        public string ItemName => "Pyrokinetic Blade";
        public string ItemDescription => "You can create bladed weapons out of flames.";
    }

    public class Magic : IItems
    {
        public string ItemName => "Magic Sword (Falchion)";
        public string ItemDescription => "This weapon has the power to slay power beings such as Gods. Consider this weapon.";
    }

    public class Water : IItems
    {
        public string ItemName => "Hyrdokinetic whip";
        public string ItemDescription => "Player can create water whips from nothing or by shaping existing water and use them to drown their targets by wrapping them up in their whips.";
    }

    public class Shocking : IItems
    {
        public string ItemName => "Electromagnetic powers";
        public string ItemDescription => "Once player is exposed to a mutagen gas, this gives them the ability to produce shock.";
    }
}