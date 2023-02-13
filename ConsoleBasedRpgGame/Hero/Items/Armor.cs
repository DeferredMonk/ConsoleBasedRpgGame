using ConsoleBasedRpgGame.Hero.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.Hero.Items
{
    internal class Armor : Item
    {
        public Armor(string name, int requiredLevel, Slots slot, ArmorType armorType, HeroAttribute armorAttribute) : base(name, requiredLevel)
        {
            this.ArmorAttribute = armorAttribute;
            this.Slot = slot;
            this.ArmorType = armorType;
        }
        public ArmorType ArmorType { get; set; }
        public HeroAttribute ArmorAttribute { get; set; }
    }
}
