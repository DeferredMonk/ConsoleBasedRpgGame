using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.Items
{/// <summary>
/// A class to create Armors
/// </summary>
    public class Armor : Item
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
