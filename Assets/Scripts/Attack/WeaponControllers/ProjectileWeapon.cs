using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapon : BaseWeapon
{
    private void Awake()
    {
        SetWeaponFactory(new ProjectileWeaponFactory(firePoint, firePoint.root, gunData.Forse));
        gunData.SetParametersInFactory(weaponFactory);
        GetWeapon(gunData.TypeWeapon);
    }

    private void FixedUpdate()
    {
        Shoot();
    }

    protected sealed override void Shoot()
    {
        if (isPlayerGun)
        {
            if (Input.GetButton("Fire1")) WeaponType();
        }
        else WeaponType();
    }
}
