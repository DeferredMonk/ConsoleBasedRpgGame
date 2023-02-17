using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;
using Newtonsoft.Json;

namespace UnitTester.ItemTests
{
    public class ArmorTest : IDisposable
    {
        public void Dispose() { }
        Armor Helmet = new("TestArmor", 1, Slots.Head, ArmorType.Plate, new(1, 1, 1));

        [Fact]
        public void Armor_Has_Correct_Name()
        {
            //Arrange
            string expected = "TestArmor";
            //Act
            string actual = Helmet.Name;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Has_Correct_RequiredLevel()
        {
            //Arrange
            int expected = 1;
            //Act
            int actual = Helmet.RequiredLevel;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Has_Correct_Slot()
        {
            //Arrange
            Slots expected = Slots.Head;
            //Act
            Slots actual = Helmet.Slot;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Has_Correct_ArmorType()
        {
            //Arrange
            ArmorType expected = ArmorType.Plate;
            //Act
            ArmorType actual = Helmet.ArmorType;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Has_Correct_Attribute()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(1, 1, 1));
            //Act
            string actual = JsonConvert.SerializeObject(Helmet.ArmorAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
