namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            this.LevelAttribute = new(1, 1, 8);
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += new Attribute(1, 1, 5);
        }
    }
}

