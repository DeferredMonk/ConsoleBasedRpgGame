using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace UnitTester.NewFolder
{
    public class WeaponTest : IDisposable
    {
        public void Dispose() { }
        Weapon weapon = new("TestWeapon", 1, WeaponType.Wands, 5);

        [Fact]
        public void Weapon_Has_Correct_Name()
        {
            //Arrange
            string expected = "TestWeapon";
            //Act
            string actual = weapon.Name;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Weapon_Has_Correct_RequiredLevel()
        {
            //Arrange
            int expected = 1;
            //Act
            int actual = weapon.RequiredLevel;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Weapon_Has_Correct_Slot()
        {
            //Arrange
            Slots expected = Slots.Weapon;
            //Act
            Slots actual = weapon.Slot;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Weapon_Has_Correct_WeaponType()
        {
            //Arrange
            WeaponType expected = WeaponType.Wands;
            //Act
            WeaponType actual = weapon.WeaponType;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Weapon_Has_Correct_Damage()
        {
            //Arrange
            int expected = 5;
            //Act
            int actual = weapon.Damage;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
