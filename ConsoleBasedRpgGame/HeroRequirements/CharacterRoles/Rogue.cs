using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.CharacterRoles
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            this.CharacterRole = "Rogue";
            this.LevelAttribute = new(2, 6, 1);
            this.ValidWeaponTypes = new List<WeaponType> { WeaponType.Daggers, WeaponType.Swords };
            this.ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(1, 4, 1);
        }
        public override double Damage()
        {
            Weapon weapon = (Weapon)equipment[Slots.Weapon];
            double WeaponDamage = weapon != null ? weapon.Damage : 1;

            double HeroDamage = WeaponDamage * (1 + LevelAttribute.Dexterity / 100);
            return HeroDamage;
        }
    }
}

