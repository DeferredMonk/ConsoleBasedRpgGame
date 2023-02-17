using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace UnitTester.CharacterTests.HeroTests.WeaponTests
{
    public class HeroWeaponEquipTest : IDisposable
    {
        public void Dispose()
        {

        }
        Hero MageHeroTest = new Mage("Mage");
        Weapon StaffTest = new Weapon("Staff", 1, WeaponType.Staffs, 5);

        [Fact]
        public void Weapon_Equipping_Replace_Successfull()
        {
            //Arrange
            Weapon toReplace = new("weapon", 1, WeaponType.Wands, 5);
            MageHeroTest.EquipW(StaffTest);
            MageHeroTest.EquipW(toReplace);
            Weapon expected = toReplace;
            //Act
            Weapon actual = (Weapon)MageHeroTest.Equipment[Slots.Weapon];
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Weapon_Equipping_Fails_Req_Level()
        {
            //Arrange
            Weapon StaffHigherLvlTest = new Weapon("Staff", 4, WeaponType.Staffs, 5);
            var exception = Assert.Throws<RequiredLevelException>(() => MageHeroTest.EquipW(StaffHigherLvlTest));
            string expected = "Your level is too low for this Staff";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
