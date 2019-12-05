namespace Decorators.Weapon
{
    public class WeaponDamageDecorator : IWeapon
    {
        public double Damage { get; set; }
        
        private readonly IWeapon _weapon;
        private readonly double _bonusDamage;

        public WeaponDamageDecorator(IWeapon weapon, double bonusDamage)
        {
            _weapon = weapon;
            _bonusDamage = bonusDamage;
            Damage = _weapon.Damage;
        }

        public void Fire()
        {
            _weapon.Damage += _bonusDamage;
            _weapon.Fire();
        }
    }
}