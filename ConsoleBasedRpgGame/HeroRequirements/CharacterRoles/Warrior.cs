using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.CharacterRoles
{
    /// <summary>
    /// A Class that to create a hero class warrior
    /// </summary>
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            this.CharacterRole = "Warrior";
            this.LevelAttribute = new(5, 2, 1);
            this.ValidWeaponTypes = new List<WeaponType> { WeaponType.Swords, WeaponType.Axes, WeaponType.Hammers };
            this.ValidArmorTypes = new List<ArmorType> { ArmorType.Plate, ArmorType.Mail };
        }
        /// <summary>
        /// Overrides LevelUp method to
        /// also increase LevelAttributes
        /// </summary>
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(3, 2, 1);
        } 
        /// <summary>
        /// Overrides Damage to calculate
        /// the correct damage amount 
        /// based on correct damage attribute
        /// </summary>
        public override double Damage()
        {
            Weapon weapon = (Weapon)equipment[Slots.Weapon];
            double WeaponDamage = weapon != null ? weapon.Damage : 1;

            double HeroDamage = WeaponDamage * (1 + TotalAttributes().Strength / 100);
            return HeroDamage;
        }       
    }
}

