using ConsoleBasedRpgGame.Hero.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    public class Mage : Hero
    {
        private List<WeaponType> validWeaponTypes = new List<WeaponType> { WeaponType.Wands, WeaponType.Staffs };
        private List<ArmorType> validArmorTypes = new List<ArmorType> { ArmorType.Cloth };
        public Mage(string name) : base(name)
        {
            this.LevelAttribute = new(1, 1, 8);

            setValidEquipTypes(validWeaponTypes, validArmorTypes);
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(1, 1, 5);
        }
    }
}

