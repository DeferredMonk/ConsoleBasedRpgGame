using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests.MageTests.WeaponTests
{
    public class RangerWeaponEquipTest : IDisposable

    {
        public void Dispose() { }
        Hero MageHeroTest = new Mage("Mage");
        Weapon StaffTest = new Weapon("Staff", 1, WeaponType.Staffs, 5);

        [Fact]
        public void Mage_Weapon_Equipping_Successfull()
        {
            //Arrange
            MageHeroTest.EquipW(StaffTest);
            string expected = JsonConvert.SerializeObject(StaffTest);
            //Act
            string actual = JsonConvert.SerializeObject(MageHeroTest.Equipment[Slots.Weapon]);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Mage_Weapon_Equipping_Fails_Invalid_Type()
        {
            //Arrange
            Weapon StaffBowTypeTest = new Weapon("Staff", 1, WeaponType.Bows, 5);
            var exception = Assert.Throws<InvalidWeaponTypeExeption>(() => MageHeroTest.EquipW(StaffBowTypeTest));
            string expected = $"Mages cannot equip Bows!";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
