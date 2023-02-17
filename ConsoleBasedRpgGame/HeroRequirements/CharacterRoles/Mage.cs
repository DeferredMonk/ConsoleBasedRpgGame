using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.CharacterRoles
{
    /// <summary>
    /// A Class that to create a hero class mage
    /// </summary>
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            this.CharacterRole = "Mage";
            this.LevelAttribute = new(1, 1, 8);
            this.ValidWeaponTypes = new List<WeaponType> { WeaponType.Wands, WeaponType.Staffs };
            this.ValidArmorTypes = new List<ArmorType> { ArmorType.Cloth };
        }
        /// <summary>
        /// Overrides LevelUp method to
        /// also increase LevelAttributes
        /// </summary>
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(1, 1, 5);
        }
        /// <summary>
        /// Overrides Damage to calculate
        /// the correct damage amount 
        /// based on correct damage attribute
        /// </summary>
        public override void Damage()
        {
            Weapon weapon = (Weapon)equipment[Slots.Weapon];
            double WeaponDamage = weapon != null ? weapon.Damage : 1;

            double HeroDamage = WeaponDamage * (1 + TotalAttributes().Intelligence / 100);
            return HeroDamage;
        }
    }
}

