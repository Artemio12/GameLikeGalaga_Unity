using UnityEngine;

public abstract class WeaponFactory
{
    private ITypeShootable typeWeapon;
    protected PoolObjects<Rigidbody> pool;
    protected Transform firePoint;
    protected Transform container;
    protected float shootForse;

    public LineRenderer LineRenderer { protected get; set; }
    public Rigidbody Projectile { protected get; set; }

    public int PoolCount { protected get; set; }
    public float Cooldown { protected get; set; }
    public bool IsAutoExpanded { protected get; set; }

    public WeaponFactory(Transform firePoint, Transform container, float shootForse)
    {
        this.firePoint = firePoint;
        this.container = container;
        this.shootForse = shootForse;
    }

    public ITypeShootable GetWeapon(EnumAttack enumAttack)
    {
        typeWeapon = CreateGun(enumAttack);
        return typeWeapon;
    }

    protected abstract ITypeShootable CreateGun(EnumAttack enumAttack);
}
