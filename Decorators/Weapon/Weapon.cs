using System;

namespace Decorators.Weapon
{
    public class Weapon : IWeapon
    {
        public double Damage { get; set; }
        
        public Weapon(double damage)
        {
            Damage = damage;
        }

        public void Fire()
        {
            Console.WriteLine($"Dealt {Damage} damage.");
        }
    }
}