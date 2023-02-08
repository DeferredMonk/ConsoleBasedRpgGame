using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    public class Mage : Hero
    {
        private Attribute onLevelUp = new(1, 1, 5);
        public Mage(string name) : base(name)
        {
            LevelAttribute = new(1, 1, 8);
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += this.onLevelUp;
        }
    }
}

