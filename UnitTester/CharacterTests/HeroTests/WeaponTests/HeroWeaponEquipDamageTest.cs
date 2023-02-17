using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace UnitTester.CharacterTests.HeroTests.WeaponTests
{
    public class HeroWeaponEquipDamageTest : IDisposable
    {
        Hero MageHeroTest = new Mage("Mage");

        [Fact]
        public void Correct_Damage_Without_Weapon()
        {
            //Arrange
            double expected = 1;
            //Act
            double actual = MageHeroTest.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Damage_With_Weapon()
        {
            //Arrange
            Weapon weapon = new("", 1, WeaponType.Staffs, 4);
            MageHeroTest.EquipW(weapon);
            double expected = 4;
            //Act
            double actual = MageHeroTest.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Damage_With_Weapon_Replaced()
        {
            //Arrange
            Weapon weapon = new("", 1, WeaponType.Staffs, 4);
            Weapon WeaponToReplace = new("", 1, WeaponType.Staffs, 6);
            MageHeroTest.EquipW(weapon);
            MageHeroTest.EquipW(WeaponToReplace);
            double expected = 6;
            //Act
            double actual = MageHeroTest.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Damage_With_Weapon_And_Armor()
        {
            //Arrange
            Weapon weapon = new("", 1, WeaponType.Staffs, 4);
            Armor Armor = new("", 1, Slots.Body, ArmorType.Cloth, new(1, 1, 500));
            MageHeroTest.EquipW(weapon);
            MageHeroTest.EquipA(Armor);
            double expected = 24;
            //Act
            double actual = MageHeroTest.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }

        public void Dispose()
        {
        }
    }
}
