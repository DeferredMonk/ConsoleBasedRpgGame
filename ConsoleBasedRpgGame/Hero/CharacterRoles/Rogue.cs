namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    internal class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            LevelAttribute = new(2, 6, 1);
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(1, 4, 1);
        }
    }
}

