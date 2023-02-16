using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements
{
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
        public virtual void LevelUp()
        {
            this.Level++;
        }
        public void EquipW(Weapon weapon)
        {
            try
            {
                if (Level < weapon.RequiredLevel) { throw new RequiredLevelException(weapon); }
                else if (!ValidWeaponTypes.Contains(weapon.WeaponType)) { throw new InvalidWeaponTypeExeption(weapon, CharacterRole); }

                equipment[0] = weapon;
                Console.WriteLine($"{weapon.Name} equipped succesfully!");
            }
            catch (RequiredLevelException e) { Console.WriteLine(e.Message); }
            catch (InvalidWeaponTypeExeption e) { Console.WriteLine(e.Message); }
        }
        public void EquipA(Armor armor)
        {
            try
            {
                if (Level < armor.RequiredLevel) { throw new RequiredLevelException(armor); }
                else if (!ValidArmorTypes.Contains(armor.ArmorType)) { throw new InvalidArmorTypeExeption(armor, CharacterRole); }

                equipment[armor.Slot] = armor;
                Console.WriteLine($"{armor.Name} equipped succesfully!");
            }
            catch (RequiredLevelException e) { Console.WriteLine(e.Message); }
            catch (InvalidArmorTypeExeption e) { Console.WriteLine(e.Message); }
        }
        public virtual void Damage()
        {

        }
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
