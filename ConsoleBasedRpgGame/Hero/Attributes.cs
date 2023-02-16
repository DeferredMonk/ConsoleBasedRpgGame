using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedRpgGame.Hero
{
    public class Attribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }  
        public int Intelligence { get; set; }

        public Attribute(int Strength, int Dexterity, int Intelligence)
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Intelligence  = Intelligence;
        }

        public static Attribute operator +(Attribute currLevel, Attribute onLelevUp)
        {
            return new Attribute(
                currLevel.Strength + onLelevUp.Strength, 
                currLevel.Dexterity + onLelevUp.Dexterity, 
                currLevel.Intelligence + onLelevUp.Intelligence);
        }
    }
}
