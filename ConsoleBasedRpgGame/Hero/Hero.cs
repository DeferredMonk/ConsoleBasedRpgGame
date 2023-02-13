using ConsoleBasedRpgGame.Hero.Items;
using ConsoleBasedRpgGame.Hero.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.Hero
{
    public abstract class Hero
    {
        private Dictionary<string, Item?> equipment = new Dictionary<string, Item?>();
        protected List<WeaponType> ValidWeaponTypes = new List<WeaponType>();
        protected List<ArmorType> ValidArmorTypes = new List<ArmorType>();

        public HeroAttribute LevelAttribute { get; set; }
        public int Level { get; set; }
        public string? Name { get; set; }
        public Dictionary<string, Item?> Equipment { get => equipment; }

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
        public void EquipW(string weapon)
        {

        }
        public void EquipA(string armor)
        {

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
                this.equipment.Add(slot.ToString(), null);
            }
        }
        protected void setValidEquipTypes(List<WeaponType> WeaponTypes, List<ArmorType> ArmorTypes)
        {
            int longestList = WeaponTypes.Count >= ArmorTypes.Count ? WeaponTypes.Count : ArmorTypes.Count;

            for (int i = 0; i < longestList; i++)
            {
                if (i < WeaponTypes.Count)
                {
                    ValidWeaponTypes.Add(WeaponTypes[i]);
                }
                if (i < ArmorTypes.Count)
                {
                    ValidArmorTypes.Add(ArmorTypes[i]);
                }
            }
        }
    }
}
