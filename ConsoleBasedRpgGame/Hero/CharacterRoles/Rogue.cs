using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    internal class Rogue : Hero
    {
        private Attribute onLevelUp = new(1, 4, 1);
        public Rogue(string name) : base(name)
        {
            LevelAttribute = new(2, 6, 1);
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += this.onLevelUp;
        }
    }
}
}
