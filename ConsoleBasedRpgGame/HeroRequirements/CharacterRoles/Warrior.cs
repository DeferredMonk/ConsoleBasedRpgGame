using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.CharacterRoles
{
    /// <summary>
    /// A Class that to create a hero class warrior
    /// </summary>
    internal class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            this.CharacterRole = "Warrior";
            this.LevelAttribute = new(3, 2, 1);
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
            this.LevelAttribute += new HeroAttribute(5, 2, 1);
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

            var HeroDamage = WeaponDamage * (1 + LevelAttribute.Strength / 100);
            Console.WriteLine(HeroDamage);
        }
    }
}

