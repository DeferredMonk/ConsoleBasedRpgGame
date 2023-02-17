using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests.HeroTests.ArmorTests
{
    public class HeroArmorEquipAttributeTest : IDisposable
    {
        public void Dispose()
        {
        }
        Hero MageHeroForTestArmor = new Mage("Mage");

        [Fact]
        public void Correct_Attributes_With_One_Armor()
        {
            //Arrange
            Armor Helmet = new("commonHelmet", 1, Slots.Head, ArmorType.Cloth, new(1, 3, 4));
            MageHeroForTestArmor.EquipA(Helmet);
            string expected = JsonConvert.SerializeObject(new HeroAttribute(2, 4, 12));

            //Act
            string actual = JsonConvert.SerializeObject(MageHeroForTestArmor.TotalAttributes());
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Attributes_With_Two_Armor()
        {
            //Arrange
            Armor Helmet = new("commonHelmet", 1, Slots.Head, ArmorType.Cloth, new(1, 3, 4));
            Armor Vest = new("CommonVest", 1, Slots.Body, ArmorType.Cloth, new(1, 2, 4));
            MageHeroForTestArmor.EquipA(Helmet);
            MageHeroForTestArmor.EquipA(Vest);
            string expected = JsonConvert.SerializeObject(new HeroAttribute(3, 6, 16));

            //Act
            string actual = JsonConvert.SerializeObject(MageHeroForTestArmor.TotalAttributes());
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Attributes_With_All_Armor()
        {
            //Arrange
            Armor Helmet = new("commonHelmet", 1, Slots.Head, ArmorType.Cloth, new(1, 3, 4));
            Armor Vest = new("CommonVest", 1, Slots.Body, ArmorType.Cloth, new(1, 2, 4));
            Armor Pants = new("CommonPants", 1, Slots.Legs, ArmorType.Cloth, new(1, 2, 4));
            MageHeroForTestArmor.EquipA(Helmet);
            MageHeroForTestArmor.EquipA(Vest);
            MageHeroForTestArmor.EquipA(Pants);
            string expected = JsonConvert.SerializeObject(new HeroAttribute(4, 8, 20));

            //Act
            string actual = JsonConvert.SerializeObject(MageHeroForTestArmor.TotalAttributes());
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct_Attributes_With_Replaced_Armor()
        {
            //Arrange
            Armor Helmet = new("commonHelmet", 1, Slots.Head, ArmorType.Cloth, new(1, 3, 4));
            Armor Vest = new("CommonVest", 1, Slots.Body, ArmorType.Cloth, new(1, 2, 4));
            Armor Pants = new("CommonPants", 1, Slots.Legs, ArmorType.Cloth, new(1, 2, 4));
            Armor NewVest = new("toreplace", 1, Slots.Body, ArmorType.Cloth, new(2, 3, 5));

            MageHeroForTestArmor.EquipA(Helmet);
            MageHeroForTestArmor.EquipA(Vest);
            MageHeroForTestArmor.EquipA(Pants);
            MageHeroForTestArmor.EquipA(NewVest);
            string expected = JsonConvert.SerializeObject(new HeroAttribute(5, 9, 21));

            //Act
            string actual = JsonConvert.SerializeObject(MageHeroForTestArmor.TotalAttributes());
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
