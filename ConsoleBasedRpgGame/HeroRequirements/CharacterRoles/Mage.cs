using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.CharacterRoles
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            this.CharacterRole = "Mage";
            this.LevelAttribute = new(1, 1, 8);
            this.ValidWeaponTypes = new List<WeaponType> { WeaponType.Wands, WeaponType.Staffs };
            this.ValidArmorTypes = new List<ArmorType> { ArmorType.Cloth };
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(1, 1, 5);
        }
    }
}

