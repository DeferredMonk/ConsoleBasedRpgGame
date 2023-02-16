using ConsoleBasedRpgGame.HeroRequirements;
using ConsoleBasedRpgGame.HeroRequirements.CharacterRoles;
using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

Hero Marco = new Mage("Marco");
Weapon Wand = new Weapon("Common Wand", 1, WeaponType.Bows, 5);
Hero Iida = new Rogue("Iida");

Weapon Dagger = new Weapon("Strong Dagger", 1, WeaponType.Wands, 2);
Armor Helmet = new Armor("Strong Helmet", 1, Slots.Head, ArmorType.Plate, new(1, 1, 1));
Armor LeatherHelmet = new Armor("Strong Helmet", 1, Slots.Head, ArmorType.Leather, new(1, 1, 1));
Armor Vest = new Armor("Strong Armor", 1, Slots.Body, ArmorType.Leather, new(5, 2, 4));
Armor Pants = new Armor("Strong Armor", 1, Slots.Legs, ArmorType.Leather, new(5, 2, 4));

Iida.EquipW(Dagger);
Iida.EquipA(Helmet);
Marco.EquipA(Helmet);
Iida.EquipA(LeatherHelmet);
Iida.EquipA(Pants);
Iida.EquipA(Vest);
for (int i = 0; i < 10; i++)
{
    Marco.LevelUp();
}
Console.WriteLine(Marco.Level);
Weapon staff = new("super wand", 1, WeaponType.Staffs, 300);
Marco.EquipW(staff);

Marco.Damage();


Iida.TotalAttributes();
Marco.TotalAttributes();


