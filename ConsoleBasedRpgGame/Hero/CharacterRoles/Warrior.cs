using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    internal class Warrior : Hero
    {
        private Attribute onLevelUp = new(5, 2, 1);
        public Warrior(string name) : base(name)
        {
            LevelAttribute = new(3, 2, 1);
        }
        public override void LevelUp()
        {
            base.LevelUp();
            this.LevelAttribute += this.onLevelUp;
        }
    }
}
}
