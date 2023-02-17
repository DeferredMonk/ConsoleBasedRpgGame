using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedRpgGame.Hero.CharacterRoles
{
    internal class Ranger : Hero
    {
            private Attribute onLevelUp = new(1, 5, 1);
            public Ranger(string name) : base(name)
            {
                LevelAttribute = new(1, 7, 1);
            }
            public override void LevelUp()
            {
                base.LevelUp();
                this.LevelAttribute += this.onLevelUp;
            }
        }
    }

