using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace UnitTester.CharacterTests.HeroTests.ArmorTests
{
    public class HeroArmorEquipTest : IDisposable
    {
        public void Dispose() { }
        Hero MageHeroForTestArmor = new Mage("Mage");

        [Fact]
        public void Armor_Head_Equipment_Successfull()
        {
            //Arrange
            Armor Helmet = new("Helmet", 1, Slots.Head, ArmorType.Cloth, new(1, 1, 1));
            MageHeroForTestArmor.EquipA(Helmet);
            Armor expected = Helmet;
            //Act
            Armor actual = (Armor)MageHeroForTestArmor.Equipment[Slots.Head];
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Vest_Equipment_Successfull()
        {
            //Arrange
            Armor Vest = new("Vest", 1, Slots.Body, ArmorType.Cloth, new(1, 1, 1));
            MageHeroForTestArmor.EquipA(Vest);
            Armor expected = Vest;
            //Act
            Armor actual = (Armor)MageHeroForTestArmor.Equipment[Slots.Body];
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Pants_Equipment_Successfull()
        {
            //Arrange
            Armor Pants = new("Pants", 1, Slots.Legs, ArmorType.Cloth, new(1, 1, 1));
            MageHeroForTestArmor.EquipA(Pants);
            Armor expected = Pants;
            //Act
            Armor actual = (Armor)MageHeroForTestArmor.Equipment[Slots.Legs];
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_Equipping_Fails_Required_Level()
        {
            //Arrange
            Armor Helmet = new("Helmet", 2, Slots.Head, ArmorType.Cloth, new(1, 1, 1));
            var exception = Assert.Throws<RequiredLevelException>(() => MageHeroForTestArmor.EquipA(Helmet));
            string expected = $"Your level is too low for this Helmet";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
