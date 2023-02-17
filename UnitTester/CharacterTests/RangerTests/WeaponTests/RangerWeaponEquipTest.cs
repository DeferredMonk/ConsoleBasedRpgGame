using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests.RangerTests.WeaponTests
{
    public class RogueWeaponEquipTest : IDisposable

    {
        public void Dispose() { }
        Hero RangerHeroTest = new Ranger("Ranger");

        [Fact]
        public void Ranger_Weapon_Equipping_Successfull()
        {
            //Arrange
            Weapon weapon = new Weapon("Staff", 1, WeaponType.Bows, 5);
            RangerHeroTest.EquipW(weapon);
            string expected = JsonConvert.SerializeObject(weapon);
            //Act
            string actual = JsonConvert.SerializeObject(RangerHeroTest.Equipment[Slots.Weapon]);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Ranger_Weapon_Equipping_Fails_Invalid_Type()
        {
            //Arrange
            Weapon StaffBowTypeTest = new Weapon("Staff", 1, WeaponType.Staffs, 5);
            var exception = Assert.Throws<InvalidWeaponTypeExeption>(() => RangerHeroTest.EquipW(StaffBowTypeTest));
            string expected = $"Rangers cannot equip Staffs!";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
