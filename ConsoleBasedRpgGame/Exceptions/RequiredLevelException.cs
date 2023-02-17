using ConsoleBasedRpgGame.HeroRequirements.Items;

namespace ConsoleBasedRpgGame.Exceptions
{
    public class RequiredLevelException : Exception
    {
        private Item CurrentItem { get; set; }
        public RequiredLevelException() { }
        public RequiredLevelException(Item item)
        {
            CurrentItem = item;
        }

        public override string Message => $"Your level is too low for this {CurrentItem.Name}";
    }
}
