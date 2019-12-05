namespace Decorators.Weapon
{
    public interface IWeapon
    {
        void Fire();
        double Damage { get; set; }
    }
}