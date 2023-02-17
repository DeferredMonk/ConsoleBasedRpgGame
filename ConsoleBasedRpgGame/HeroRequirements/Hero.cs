using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements
{
    /// <summary>
    /// An abstract class for hero creation
    /// This class contains all needed 
    /// common variables and methods 
    /// between classes
    /// </summary>
    public abstract class Hero
    {
        protected Dictionary<Slots, Item?> equipment = new Dictionary<Slots, Item?>();
        protected List<WeaponType> ValidWeaponTypes;
        protected List<ArmorType> ValidArmorTypes;

        public HeroAttribute LevelAttribute { get; set; }
        public int Level { get; set; }
        public string? Name { get; set; }
        public string CharacterRole { get; set; }

        public Hero(string name)
        {
            this.Name = name;
            this.Level = 1;
            setEquipmentStartingValues();
        }
        /// <summary>
        /// Increases hero level by one
        /// </summary>
        public virtual void LevelUp()
        {
            this.Level++;
        }
        /// <summary>
        /// Equips a weapon if requirements are met
        /// otherwise throws error
        /// </summary>
        /// <param name="weapon"></param> Weapon to equip
        public void EquipW(Weapon weapon)
        {
            if (Level < weapon.RequiredLevel) { throw new RequiredLevelException(weapon); }
            else if (!ValidWeaponTypes.Contains(weapon.WeaponType)) { throw new InvalidWeaponTypeExeption(weapon, CharacterRole); }

            equipment[0] = weapon;
            Console.WriteLine($"{weapon.Name} equipped succesfully!");
        }
        /// <summary>
        /// Equips a armor if requirements are met
        /// otherwise throws error
        /// </summary>
        /// <param name="armor"></param> An armor to equip
        /// <exception cref="RequiredLevelException"></exception> If required level is not met
        /// <exception cref="InvalidArmorTypeExeption"></exception> If class cannot equip armor type
        public void EquipA(Armor armor)
        {

            if (Level < armor.RequiredLevel) { throw new RequiredLevelException(armor); }
            else if (!ValidArmorTypes.Contains(armor.ArmorType)) { throw new InvalidArmorTypeExeption(armor, CharacterRole); }

            equipment[armor.Slot] = armor;
            Console.WriteLine($"{armor.Name} equipped succesfully!");

        }
        /// <summary>
        /// Calculates damage of hero
        /// </summary>
        public virtual void Damage() { }
        /// <summary>
        /// Calculates total attributes
        /// </summary>
        public void TotalAttributes()
        {
            var EquippedArmor = equipment.Where(kvp => kvp.Key != Slots.Weapon).Select(kvp => (Armor?)kvp.Value);
            Console.WriteLine(EquippedArmor.Aggregate(LevelAttribute, (acc, curr) =>
            {
                if (curr != null) return acc + curr.ArmorAttribute;
                else return acc;
            }));
        }
        public void Display()
        {

        }
        /// <summary>
        /// Adds to equipment dictionary 
        /// Needed values.
        /// </summary>
        private void setEquipmentStartingValues()
        {
            foreach (Slots slot in Enum.GetValues(typeof(Slots)))
            {
                this.equipment.Add(slot, null);
            }
        }
    }
}
