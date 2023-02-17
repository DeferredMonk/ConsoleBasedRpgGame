using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace UnitTester.CharacterTests.WarriorTests.ArmorTests
{
    public class WarriorArmorEquipTest : IDisposable
    {
        Hero WarriorHeroForTestArmor = new Warrior("Warrior");

        [Fact]
        public void Armor_Vest_Equipment_Successfull()
        {
            //Arrange
            Armor Vest = new("Vest", 1, Slots.Body, ArmorType.Plate, new(1, 1, 1));
            WarriorHeroForTestArmor.EquipA(Vest);
            Armor expected = Vest;
            //Act
            Armor actual = (Armor)WarriorHeroForTestArmor.Equipment[Slots.Body];
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Equipping_Fails_Invalid_Type()
        {
            //Arrange
            Armor HelmetPlate = new("Helmet", 1, Slots.Head, ArmorType.Cloth, new(1, 1, 1));
            var exception = Assert.Throws<InvalidArmorTypeExeption>(() => WarriorHeroForTestArmor.EquipA(HelmetPlate));
            string expected = $"Warriors cannot equip Cloth armors!";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }

        public void Dispose()
        {
        }
    }
}
