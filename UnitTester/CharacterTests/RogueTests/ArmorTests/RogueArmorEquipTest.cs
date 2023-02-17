using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace UnitTester.CharacterTests.RogueTests.ArmorTests
{
    public class RogueArmorEquipTest : IDisposable
    {
        Hero RogueHeroForTestArmor = new Rogue("Rogue");

        [Fact]
        public void Armor_Vest_Equipment_Successfull()
        {
            //Arrange
            Armor Vest = new("Vest", 1, Slots.Body, ArmorType.Leather, new(1, 1, 1));
            RogueHeroForTestArmor.EquipA(Vest);
            Armor expected = Vest;
            //Act
            Armor actual = (Armor)RogueHeroForTestArmor.Equipment[Slots.Body];
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Equipping_Fails_Invalid_Type()
        {
            //Arrange
            Armor HelmetPlate = new("Helmet", 1, Slots.Head, ArmorType.Plate, new(1, 1, 1));
            var exception = Assert.Throws<InvalidArmorTypeExeption>(() => RogueHeroForTestArmor.EquipA(HelmetPlate));
            string expected = $"Rogues cannot equip Plate armors!";
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
