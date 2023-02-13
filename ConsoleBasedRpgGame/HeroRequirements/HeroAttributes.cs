using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedRpgGame.HeroRequirements
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }  
        public int Intelligence { get; set; }

        public HeroAttribute(int Strength, int Dexterity, int Intelligence)
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Intelligence  = Intelligence;
        }

        public static HeroAttribute operator +(HeroAttribute currLevel, HeroAttribute onLelevUp)
        {
            return new HeroAttribute(
                currLevel.Strength + onLelevUp.Strength, 
                currLevel.Dexterity + onLelevUp.Dexterity, 
                currLevel.Intelligence + onLelevUp.Intelligence);
        }
    }
}
