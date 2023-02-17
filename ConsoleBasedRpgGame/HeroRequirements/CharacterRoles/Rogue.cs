using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.CharacterRoles
{
    /// <summary>
    /// A Class that to create a hero class rogue
    /// </summary>
    internal class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            this.CharacterRole = "Rogue";
            this.LevelAttribute = new(2, 6, 1);
            this.ValidWeaponTypes = new List<WeaponType> { WeaponType.Daggers, WeaponType.Swords };
            this.ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
        }
        /// <summary>
        /// Overrides LevelUp method to
        /// also increase LevelAttributes
        /// </summary>
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(1, 4, 1);
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

            var HeroDamage = WeaponDamage * (1 + LevelAttribute.Dexterity / 100);
            Console.WriteLine(HeroDamage);
        }
    }
}

