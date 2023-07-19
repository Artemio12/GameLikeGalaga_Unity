using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponFactory
{
    private ITypeShootable typeWeapon;
    protected PoolObjects<Rigidbody> pool;
    protected Transform firePoint;
    protected Transform container;
    protected float shootForse;

    public LineRenderer LineRenderer { get; set; }
    public Rigidbody Projectile { get; set; }

    public int PoolCount { get; set; }
    public float Cooldown { get; set; }
    public bool IsAutoExpanded { get; set; }

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
