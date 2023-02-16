using ConsoleBasedRpgGame.HeroRequirements.Items;
using ConsoleBasedRpgGame.HeroRequirements.Items.ItemsEnums;

namespace UnitTester.NewFolder
{
    public class WeaponTest : IDisposable
    {
        public void Dispose()
        {

        }
        Weapon weapon = new("TestWeapon", 1, WeaponType.Wands, 5);
    }
}
