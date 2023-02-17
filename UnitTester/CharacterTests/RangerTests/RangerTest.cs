using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests
{
    public class RangerTest : IDisposable
    {
        Hero RangerHeroTest = new Ranger("Ranger");
        public void Dispose()
        {
        }

        [Fact]
        public void Hero_Correct_Name_Test()
        {
            //Arrange
            string expected = "Ranger";
            //Act
            string actual = RangerHeroTest.Name;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_Starting_Level_Correct_Test()
        {
            //Arrange
            int expected = 1;
            //Act
            int actual = RangerHeroTest.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Starting_Attributes()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(1, 7, 1));

            //Act
            string actual = JsonConvert.SerializeObject(RangerHeroTest.LevelAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]

        public void Leveling_Up_Levels_Hero_Correctly()
        {
            //Arrange
            RangerHeroTest.LevelUp();
            int expected = 2;
            //Act
            int actual = RangerHeroTest.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Leveling_Up_Updates_Attributes_Correctly()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(2, 12, 2));
            RangerHeroTest.LevelUp();
            //Act
            string actual = JsonConvert.SerializeObject(RangerHeroTest.LevelAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
