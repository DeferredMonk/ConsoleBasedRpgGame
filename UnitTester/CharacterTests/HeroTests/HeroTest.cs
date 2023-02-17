using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;

namespace UnitTester.CharacterTests.HeroTests
{
    public class HeroTest : IDisposable
    {
        public void Dispose()
        {

        }
        [Fact]
        public void Display_Correct_Info()
        {
            //Arrange
            Hero hero = new Mage("test");
            string expected = "Name: test CLass: Mage Level: 1 Total strength: 1 Total dexterity: 1 Total intelligence: 8 Damage: 1";
            //Act
            string actual = hero.Display();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
