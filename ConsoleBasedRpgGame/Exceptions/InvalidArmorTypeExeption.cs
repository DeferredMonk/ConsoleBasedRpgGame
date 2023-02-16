using ConsoleBasedRpgGame.HeroRequirements.Items;

namespace ConsoleBasedRpgGame.Exceptions
{
    internal class InvalidArmorTypeExeption : Exception
    {
        private Armor CurrentArmor { get; set; }
        private string CharacterRole { get; set; }
        public InvalidArmorTypeExeption() { }
        public InvalidArmorTypeExeption(Armor Armor, string characterRole)
        {
            CharacterRole = characterRole;
            CurrentArmor = Armor;
        }

        public override string Message => $"{CharacterRole}s cannot equip {CurrentArmor.ArmorType} armors!";
    }
}

