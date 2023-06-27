using UnityEngine;

public enum EnumAttack
{
    None = 0,
    DefaultShot = 1,
    Rocket = 2,
    Laser = 3,
}

public class GunWeaponFactory : WeaponFactory
{
    public GunWeaponFactory(Transform firePoint, Rigidbody projectile, float forse) : base(firePoint, projectile, forse) { }
     
    public override ITypeShootable CreateGun(EnumAttack enumAttack)
    {   
        ITypeShootable typeGun = null;
        switch (enumAttack)
        {
            case EnumAttack.DefaultShot:
                typeGun = new DefaulShootGun(firePoint, projectile, forse);
                break;
            case EnumAttack.Rocket:
                typeGun = new RocketGun();
                break;
            case EnumAttack.Laser:
                typeGun = new LaserGun();
                break;
            default:
                Debug.LogError("Ошибка, тип атаки не существует");
                break;
        }
        return typeGun;
    }
}
