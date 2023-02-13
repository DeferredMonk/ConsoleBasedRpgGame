namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    internal class Ranger : Hero
    {
        public Ranger(string name) : base(name)
        {
            LevelAttribute = new(1, 7, 1);
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(1, 5, 1);
        }
    }
}

