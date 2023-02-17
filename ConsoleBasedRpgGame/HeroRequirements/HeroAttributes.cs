namespace ConsoleBasedRpgGame.HeroRequirements
{
    /// <summary>
    /// This is a class for 
    /// Hero attributes creation
    /// </summary>
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute(int Strength, int Dexterity, int Intelligence)
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
        }
        /// <summary>
        /// This overrides the + operator
        /// to plus the values together
        /// </summary>
        /// <param name="currLevel"></param> current level as HeroAttribute
        /// <param name="onLelevUp"></param> level to add to current level
        /// <returns>Hero attribute with added values</returns>
        public static HeroAttribute operator +(HeroAttribute currLevel, HeroAttribute onLelevUp)
        {
            return new HeroAttribute(
                currLevel.Strength + onLelevUp.Strength,
                currLevel.Dexterity + onLelevUp.Dexterity,
                currLevel.Intelligence + onLelevUp.Intelligence);
        }
    }
}
