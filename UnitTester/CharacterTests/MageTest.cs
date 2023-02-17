﻿using ConsoleBasedRpgGame.Exceptions;
using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;
using Newtonsoft.Json;

namespace UnitTester.CharacterTests
{
    public class MageTest : IDisposable
    {
        Hero MageHeroTest = new Mage("Mage");
        Weapon StaffTest = new Weapon("Staff", 1, WeaponType.Staffs, 5);


        public void Dispose()
        {
        }

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
        [Fact]
        public void Weapon_Equipping_Successfull()
        {
            //Arrange
            MageHeroTest.EquipW(StaffTest);
            string expected = JsonConvert.SerializeObject(StaffTest);
            //Act
            string actual = JsonConvert.SerializeObject(MageHeroTest.Equipment[Slots.Weapon]);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Weapon_Equipping_Fails_Req_Level()
        {
            //Arrange
            Weapon StaffHigherLvlTest = new Weapon("Staff", 4, WeaponType.Staffs, 5);
            var exception = Assert.Throws<RequiredLevelException>(() => MageHeroTest.EquipW(StaffHigherLvlTest));
            string expected = "Your level is too low for this Staff";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Weapon_Equipping_Fails_Invalid_Type()
        {
            //Arrange
            Weapon StaffBowTypeTest = new Weapon("Staff", 1, WeaponType.Bows, 5);
            var exception = Assert.Throws<InvalidWeaponTypeExeption>(() => MageHeroTest.EquipW(StaffBowTypeTest));
            string expected = $"Mages cannot equip Bows!";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Head_Equipment_Successfull()
        {
            //Arrange
            Armor Helmet = new("Helmet", 1, Slots.Head, ArmorType.Cloth, new(1, 1, 1));
            MageHeroTest.EquipA(Helmet);
            Armor expected = Helmet;
            //Act
            Armor actual = (Armor)MageHeroTest.Equipment[Slots.Head];
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Vest_Equipment_Successfull()
        {
            //Arrange
            Armor Vest = new("Vest", 1, Slots.Body, ArmorType.Cloth, new(1, 1, 1));
            MageHeroTest.EquipA(Vest);
            Armor expected = Vest;
            //Act
            Armor actual = (Armor)MageHeroTest.Equipment[Slots.Body];
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Pants_Equipment_Successfull()
        {
            //Arrange
            Armor Pants = new("Pants", 1, Slots.Legs, ArmorType.Cloth, new(1, 1, 1));
            MageHeroTest.EquipA(Pants);
            Armor expected = Pants;
            //Act
            Armor actual = (Armor)MageHeroTest.Equipment[Slots.Legs];
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Equipping_Fails_Invalid_Type()
        {
            //Arrange
            Armor HelmetPlate = new("Helmet", 1, Slots.Head, ArmorType.Plate, new(1, 1, 1));
            var exception = Assert.Throws<InvalidArmorTypeExeption>(() => MageHeroTest.EquipA(HelmetPlate));
            string expected = $"Mages cannot equip Plate armors!";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armor_Equipping_Fails_Required_Level()
        {
            //Arrange
            Armor Helmet = new("Helmet", 2, Slots.Head, ArmorType.Cloth, new(1, 1, 1));
            var exception = Assert.Throws<RequiredLevelException>(() => MageHeroTest.EquipA(Helmet));
            string expected = $"Your level is too low for this Helmet";
            //Act
            string actual = exception.Message;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}