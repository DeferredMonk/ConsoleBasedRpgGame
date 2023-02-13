using ConsoleBasedRpgGame.HeroRequirements.Items;

namespace ConsoleBasedRpgGame.Exceptions
{
    internal class InvalidWeaponTypeExeption : Exception
    {
        private Weapon CurrentWeapon { get; set; }
        private string CharacterRole { get; set; }
        public InvalidWeaponTypeExeption() { }
        public InvalidWeaponTypeExeption(Weapon weapon, string characterRole)
        {
            CharacterRole = characterRole;
            CurrentWeapon = weapon;
        }

        public override string Message => $"{CharacterRole}s cannot equip {CurrentWeapon.WeaponType}!";
    }
}
