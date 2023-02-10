using ConsoleBasedRpgGame.Hero.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.Hero.Items
{
    internal class Weapon : Item
    {
        public Weapon(string name, int requiredLevel, WeaponType weaponType, int damage) : base(name, requiredLevel)
        {
            this.Type = weaponType;
            this.Damage = damage;
        }
        public WeaponType Type { get; set; }
        public int Damage { get; set; }
    }
}
