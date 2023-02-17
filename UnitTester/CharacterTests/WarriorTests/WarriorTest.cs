using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests
{
    public class WarriorTest : IDisposable
    {
        Hero WarriorHeroTest = new Warrior("Warrior");
        public void Dispose()
        {
        }

        [Fact]
        public void Hero_Correct_Name_Test()
        {
            //Arrange
            string expected = "Warrior";
            //Act
            string actual = WarriorHeroTest.Name;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_Starting_Level_Correct_Test()
        {
            //Arrange
            int expected = 1;
            //Act
            int actual = WarriorHeroTest.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Starting_Attributes()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(5, 2, 1));

            //Act
            string actual = JsonConvert.SerializeObject(WarriorHeroTest.LevelAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]

        public void Leveling_Up_Levels_Hero_Correctly()
        {
            //Arrange
            WarriorHeroTest.LevelUp();
            int expected = 2;
            //Act
            int actual = WarriorHeroTest.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Leveling_Up_Updates_Attributes_Correctly()
        {
            //Arrange
            string expected = JsonConvert.SerializeObject(new HeroAttribute(8, 4, 2));
            WarriorHeroTest.LevelUp();
            //Act
            string actual = JsonConvert.SerializeObject(WarriorHeroTest.LevelAttribute);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
