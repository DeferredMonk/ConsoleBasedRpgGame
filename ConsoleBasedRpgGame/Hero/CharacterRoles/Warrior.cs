namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    internal class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            LevelAttribute = new(3, 2, 1);
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new HeroAttribute(5, 2, 1);
        }
    }
}

