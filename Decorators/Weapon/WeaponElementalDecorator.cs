using System;

namespace Decorators.Weapon
{
    public class WeaponElementalDecorator : IWeapon
    {
        public double Damage { get; set; }

        private readonly Elements _element;
        private readonly IWeapon _weapon;

        public WeaponElementalDecorator(IWeapon weapon, Elements element)
        {
            _element = element;
            _weapon = weapon;
            Damage = _weapon.Damage;
        }

        public void Fire()
        {
            _weapon.Fire();

            var msg = _element switch
            {
                Elements.Fire        => $"Enemy is now burning for {_weapon.Damage / 9.4:0.###} damage per second.",
                Elements.Electricity =>  "Enemy is now stunned.",
                Elements.Toxin       => $"Enemy is now taking DoT damage for {_weapon.Damage / 6.7:0.###} damage per second.",
                Elements.Cold        =>  "Enemy is now frozen.",
                                   _ => throw new ArgumentOutOfRangeException()
            };
            Console.WriteLine(msg);
        }
    }
}