using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests
{
    public class RogueTest : IDisposable
    {
        Hero RogueHeroTest = new Rogue("Rogue");
        public void Dispose()
        {
        }

        [Fact]
        public void Hero_Correct_Name_Test()
        {
            //Arrange
            string expected = "Rogue";
            //Act
            string actual = RogueHeroTest.Name;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_Starting_Level_Correct_Test()
        {
            //Arrange
            int expected = 1;
            //Act
            int actual = RogueHeroTest.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Starting_Attributes()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(2, 6, 1));

            //Act
            string actual = JsonConvert.SerializeObject(RogueHeroTest.LevelAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]

        public void Leveling_Up_Levels_Hero_Correctly()
        {
            //Arrange
            RogueHeroTest.LevelUp();
            int expected = 2;
            //Act
            int actual = RogueHeroTest.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Leveling_Up_Updates_Attributes_Correctly()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(3, 10, 2));
            RogueHeroTest.LevelUp();
            //Act
            string actual = JsonConvert.SerializeObject(RogueHeroTest.LevelAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
