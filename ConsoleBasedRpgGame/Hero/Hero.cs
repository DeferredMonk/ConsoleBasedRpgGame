using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedRpgGame.Hero
{
    public abstract class Hero
    {
        private int level = 1;
        protected string[] equipment;
        protected string[] validWeaponTypes;
        protected string[] ValidArmorTypes;

        public Attribute LevelAttribute { get; set; }
        public int Level { get { return level; }}
        public string? Name { get; set; }

        public Hero(string name)
        {
            this.Name = name;  
        }
        public virtual void LevelUp()
        {
            this.level++;
        }
        public void EquipW(string weapon)
        {

        }
        public void EquipA(string armor)
        {

        }
        public void Damage()
        {

        }
        public void TotalAttributes() 
        { 

        }
        public void Display()
        {

        }

    }
}
