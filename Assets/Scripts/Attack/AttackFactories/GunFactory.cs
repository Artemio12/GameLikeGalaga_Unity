using UnityEngine;

public enum EnumAttack
{
    None = 0,
    DefaultShot = 1,
    Rocket = 2,
    Laser = 3,
}

public class GunFactory : WeaponFactory
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
                Debug.Log("���������");
                break;
            default:
                Debug.LogError("������, ��� ����� �� ����������");
                break;
        }
        return typeGun;
    }

    protected PoolObjects<Rigidbody> CreateProjectilePool(Transform container)
    {
        pool = new PoolObjects<Rigidbody>(container, Projectile, PoolCount);
        pool.AutoExpand = IsAutoExpanded;
        return pool;
    }
}
