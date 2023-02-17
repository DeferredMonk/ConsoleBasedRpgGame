using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests
{
    public class MageTest : IDisposable
    {
        Hero MageHeroTest = new Mage("Mage");

        public void Dispose() { }

        [Fact]
        public void Hero_Correct_Name_Test()
        {
            //Arrange
            string expected = "Mage";
            //Act
            string actual = MageHeroTest.Name;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_Starting_Level_Correct_Test()
        {
            //Arrange
            int expected = 1;
            //Act
            int actual = MageHeroTest.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Starting_Attributes()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(1, 1, 8));

            //Act
            string actual = JsonConvert.SerializeObject(MageHeroTest.LevelAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]

        public void Leveling_Up_Levels_Hero_Correctly()
        {
            //Arrange
            MageHeroTest.LevelUp();
            int expected = 2;
            //Act
            int actual = MageHeroTest.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Leveling_Up_Updates_Attributes_Correctly()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(2, 2, 13));
            MageHeroTest.LevelUp();
            //Act
            string actual = JsonConvert.SerializeObject(MageHeroTest.LevelAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }





    }
}
