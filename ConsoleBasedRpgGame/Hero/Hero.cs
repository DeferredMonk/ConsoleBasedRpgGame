namespace ConsoleBasedRpgGame.Hero
{
    public abstract class Hero
    {
        protected string[] equipment;
        protected string[] validWeaponTypes;
        protected string[] ValidArmorTypes;

        public Attribute LevelAttribute { get; set; }
        public int Level { get; set; }
        public string? Name { get; set; }

        public Hero(string name)
        {
            this.Name = name;
            this.Level = 1;
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

    }
}
