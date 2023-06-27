using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponFactory 
{
    protected Rigidbody projectile;
    protected Transform firePoint;

    protected float forse;

    public WeaponFactory(Transform firePoint, Rigidbody projectile, float forse)
    {
        this.firePoint = firePoint;
        this.projectile = projectile;
        this.forse = forse;
    }

    public abstract ITypeShootable CreateGun(EnumAttack enumAttack);
}
