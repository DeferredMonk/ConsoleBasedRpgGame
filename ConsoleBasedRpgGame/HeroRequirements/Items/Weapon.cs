using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.Items
{
    public class Weapon : Item
    {
        public Weapon(string name, int requiredLevel, WeaponType weaponType, int damage) : base(name, requiredLevel)
        {
            this.WeaponType = weaponType;
            this.Damage = damage;
        }
        public WeaponType WeaponType { get; set; }
        public int Damage { get; set; }
    }
}
