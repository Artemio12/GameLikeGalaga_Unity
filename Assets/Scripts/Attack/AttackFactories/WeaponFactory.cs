using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponFactory 
{
    //protected Rigidbody projectile;
    protected PoolMono<Rigidbody> poolMono;
    protected Transform firePoint;

    protected float forse;

    public WeaponFactory(Transform firePoint, PoolMono<Rigidbody> poolMono, float forse)
    {
        this.firePoint = firePoint;
        this.poolMono = poolMono;
        this.forse = forse;
    }

    public abstract ITypeShootable CreateGun(EnumAttack enumAttack);
}
