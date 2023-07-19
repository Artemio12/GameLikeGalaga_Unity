using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : Weapon
{
    private void Awake()
    {
        SetFactory(new GunFactory(firePoint, firePoint.root, gunData.Forse)); // подача параметров в экземпляр класса фабрики
        gunData.SetParametersInFactory(weaponFactory);
        GetGun(gunData.Attack);
    }

    private void FixedUpdate()
    {
        DoEnemyShoot();
    }

    private void DoEnemyShoot()
    {
        WeaponType();
    }
}
