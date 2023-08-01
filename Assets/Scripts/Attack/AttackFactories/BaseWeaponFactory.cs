using UnityEngine;

public enum EnumWeapon
{
    None = 0,
    Bullet = 1,
    Rocket = 2,
    Laser = 3,
}

public abstract class BaseWeaponFactory
{
    private ITypeShootable weapon;
    protected Transform firePoint;
    protected float forse;

    public Rigidbody Projectile { protected get; set; }
    public int PoolCount { protected get; set; }
    public float Cooldown { protected get; set; }
    public bool IsAutoExpanded { protected get; set; }

    public BaseWeaponFactory(Transform firePoint, float forse)
    {
        this.firePoint = firePoint;
        this.forse = forse;
    }

    public ITypeShootable GetWeapon(EnumWeapon typeWeapon)
    {
        weapon = CreateGun(typeWeapon);
        return weapon;
    }

    protected abstract ITypeShootable CreateGun(EnumWeapon typeWeapon);
}
