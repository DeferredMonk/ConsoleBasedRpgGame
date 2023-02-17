using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests.RogueTests.WeaponTests
{
    public class RogueWeaponEquipTest : IDisposable

    {
        public void Dispose() { }
        Hero RogueHeroTest = new Rogue("Rogue");

        [Fact]
        public void Rogue_Weapon_Equipping_Successfull()
        {
            //Arrange
            Weapon weapon = new Weapon("", 1, WeaponType.Swords, 5);
            RogueHeroTest.EquipW(weapon);
            string expected = JsonConvert.SerializeObject(weapon);
            //Act
            string actual = JsonConvert.SerializeObject(RogueHeroTest.Equipment[Slots.Weapon]);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Rogue_Weapon_Equipping_Fails_Invalid_Type()
        {
            //Arrange
            Weapon weapon = new Weapon("Staff", 1, WeaponType.Staffs, 5);
            var exception = Assert.Throws<InvalidWeaponTypeExeption>(() => RogueHeroTest.EquipW(weapon));
            string expected = $"Rogues cannot equip Staffs!";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
