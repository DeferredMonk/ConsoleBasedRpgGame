using ConsoleBasedRpgGame.Hero;
using ConsoleBasedRpgGame.Hero.CharacterRoles;
using ConsoleBasedRpgGame.Hero.Items;

Hero Marco = new Mage("Marco");
Item commonAxe = new Weapon("Common Axe", 1);

Console.WriteLine(commonAxe.RequiredLevel);
