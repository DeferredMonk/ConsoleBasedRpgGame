using ConsoleBasedRpgGame.Hero.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.Hero.Items
{
    internal class Armor : Item
    {
        public Armor(string name, int requiredLevel, ArmorType armorType, Attribute armorAttribute) : base(name, requiredLevel)
        {

        }
    }
}
