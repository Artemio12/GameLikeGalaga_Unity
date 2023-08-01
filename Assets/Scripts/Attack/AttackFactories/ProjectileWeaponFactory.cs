using UnityEngine;

public class ProjectileWeaponFactory : BaseWeaponFactory
{
    private Transform container;
    private PoolObjects<Rigidbody> pool;
   
    public ProjectileWeaponFactory(Transform firePoint, Transform container, float shootForse) : base(firePoint, shootForse)
    {
        
        this.container = container;
    }
   
    protected sealed override ITypeShootable CreateGun(EnumWeapon typeWeapon)
    {
        ITypeShootable weapon = null;
        CreateProjectilePool(container);
        switch (typeWeapon)
        {
            case EnumWeapon.None:
                Debug.LogError("typeWeapon not selected");
                break;
            case EnumWeapon.Bullet:
                weapon = new DefaulShootGun(firePoint, pool, forse, Cooldown);
                break;
            case EnumWeapon.Rocket:
                weapon = new RocketGun();
                break;
            default:
                Debug.LogError($"{typeWeapon} doesn't exist in ProjectileWeaponFactory");
                break;
        }
        return weapon;
    }
    private PoolObjects<Rigidbody> CreateProjectilePool(Transform container)
    {
        pool = new PoolObjects<Rigidbody>(container, Projectile, PoolCount);
        pool.AutoExpand = IsAutoExpanded;
        return pool;
    }


}
