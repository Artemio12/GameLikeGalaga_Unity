using UnityEngine;

public sealed class GunFactory : WeaponFactory
{
    public GunFactory(Transform firePoint, Transform container, float shootForse) : base(firePoint, container, shootForse)
    {
        CreateProjectilePool(container);
    }
     
    protected override ITypeShootable CreateGun(EnumAttack enumAttack)
    {   
        ITypeShootable typeGun = null;
        switch (enumAttack)
        {
            case EnumAttack.DefaultShot:
                typeGun = new DefaulShootGun(firePoint, CreateProjectilePool(container), shootForse, Cooldown);
                break;
            case EnumAttack.Rocket:
                typeGun = new RocketGun();
                break;
            case EnumAttack.Laser:
                typeGun = new LaserGun(firePoint, LineRenderer, shootForse);
                break;
            default:
                Debug.LogError("Ошибка, тип атаки не существует");
                break;
        }
        return typeGun;
    }

    private PoolObjects<Rigidbody> CreateProjectilePool(Transform container)
    {
        pool = new PoolObjects<Rigidbody>(container, Projectile, PoolCount);
        pool.AutoExpand = IsAutoExpanded;
        return pool;
    }
}
