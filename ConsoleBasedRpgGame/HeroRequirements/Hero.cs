using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;
using System.Text;

namespace ConsoleBasedRpgGame.HeroRequirements
{
    public abstract class Hero
    {
        protected Dictionary<Slots, Item?> equipment = new Dictionary<Slots, Item?>();
        protected List<WeaponType> ValidWeaponTypes;
        protected List<ArmorType> ValidArmorTypes;
        protected StringBuilder SB = new();

        public HeroAttribute LevelAttribute { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string CharacterRole { get; set; }
        public Dictionary<Slots, Item?> Equipment { get => equipment; }

        public Hero(string name)
        {
            this.Name = name;
            this.Level = 1;
            setEquipmentStartingValues();
        }
        public virtual void LevelUp()
        {
            this.Level++;
        }
        public void EquipW(Weapon weapon)
        {
            if (Level < weapon.RequiredLevel) { throw new RequiredLevelException(weapon); }
            else if (!ValidWeaponTypes.Contains(weapon.WeaponType)) { throw new InvalidWeaponTypeExeption(weapon, CharacterRole); }

            equipment[0] = weapon;
            Console.WriteLine($"{weapon.Name} equipped succesfully!");
        }
        public void EquipA(Armor armor)
        {
            if (Level < armor.RequiredLevel) { throw new RequiredLevelException(armor); }
            else if (!ValidArmorTypes.Contains(armor.ArmorType)) { throw new InvalidArmorTypeExeption(armor, CharacterRole); }

            equipment[armor.Slot] = armor;
            Console.WriteLine($"{armor.Name} equipped succesfully!");
        }
        public virtual double Damage()
        {
            return 0;
        }
        public HeroAttribute TotalAttributes()
        {
            var EquippedArmor = equipment.Where(kvp => kvp.Key != Slots.Weapon).Select(kvp => (Armor?)kvp.Value);

            return EquippedArmor.Aggregate(LevelAttribute, (acc, curr) =>
            {
                if (curr != null) return acc + curr.ArmorAttribute;
                else return acc;
            });
        }
        public void Display()
        {
            SB.Append($"Name: {this.Name}{Environment.NewLine}CLass: {this.CharacterRole}{Environment.NewLine}Level: {this.Level}{Environment.NewLine}Total strength: {this.LevelAttribute.Strength}{Environment.NewLine}Total dexterity: {this.LevelAttribute.Dexterity}{Environment.NewLine}Total intelligence: {this.LevelAttribute.Intelligence}{Environment.NewLine}Damage: {Damage()}");
            Console.WriteLine(SB.ToString());
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
