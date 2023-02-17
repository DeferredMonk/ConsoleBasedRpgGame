using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.CharacterRoles
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name)
        {
            this.CharacterRole = "Ranger";
            this.LevelAttribute = new(1, 7, 1);
            this.ValidWeaponTypes = new List<WeaponType> { WeaponType.Bows };
            this.ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(1, 5, 1);
        }
        public override double Damage()
        {
            Weapon weapon = (Weapon)equipment[Slots.Weapon];
            double WeaponDamage = weapon != null ? weapon.Damage : 1;

            return WeaponDamage * (1 + TotalAttributes().Dexterity / 100);
        }
    }
}

