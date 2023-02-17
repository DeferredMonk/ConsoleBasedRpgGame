using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace ConsoleBasedRpgGame.HeroRequirements.Items
{/// <summary>
/// An abstract class to create items
/// </summary>
    public abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slots Slot { get; set; }

        public Item(string name, int requiredLevel)
        {
            this.Name = name;
            this.RequiredLevel = requiredLevel;
        }
    }
}
