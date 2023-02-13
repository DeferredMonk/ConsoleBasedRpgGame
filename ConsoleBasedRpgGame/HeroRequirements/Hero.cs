using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements
{
    public abstract class Hero
    {
        private Dictionary<Slots, Item?> equipment = new Dictionary<Slots, Item?>();
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
                Console.WriteLine(equipment[armor.Slot].Name);
            }
            catch (RequiredLevelException e) { Console.WriteLine(e.Message); }
            catch (InvalidArmorTypeExeption e) { Console.WriteLine(e.Message); }
        }
        public void Damage()
        {

        }
        public void TotalAttributes()
        {

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
