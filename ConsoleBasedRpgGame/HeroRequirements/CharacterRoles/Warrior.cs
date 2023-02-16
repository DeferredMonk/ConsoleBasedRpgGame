using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.CharacterRoles
{
    internal class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            this.CharacterRole = "Warrior";
            this.LevelAttribute = new(3, 2, 1);
            this.ValidWeaponTypes = new List<WeaponType> { WeaponType.Swords, WeaponType.Axes, WeaponType.Hammers };
            this.ValidArmorTypes = new List<ArmorType> { ArmorType.Plate, ArmorType.Mail };
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(5, 2, 1);
        }
    }
}

