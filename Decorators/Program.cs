using Decorators.Weapon;

namespace Decorators
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon stack = new Weapon.Weapon(10.0);
            stack = new WeaponDamageDecorator(stack, 15.0);
            stack = new WeaponElementalDecorator(stack, Elements.Toxin);
            stack.Fire();
        }
    }
}