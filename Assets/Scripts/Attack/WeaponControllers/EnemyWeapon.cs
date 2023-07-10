using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : Weapon
{
    private void Awake()
    {
        projectilePool = new ProjectilePool(isAutoExpanded);
        poolMono = projectilePool.CreateObjectsInPool(firePoint, projectileData.ProjectileRigidbody, projectileData.PoolCount);
        SetFactory(new GunWeaponFactory(firePoint, poolMono, projectileData.Forse)); // подача параметров в экземпл€р класса фабрики
        SetTypeGun(GetGun(attack)); // ссылка на интерфейс
    }

    private void FixedUpdate()
    {
        DoEnemyShoot();
    }

    private void DoEnemyShoot()
    {
        if (timer.TimeCount() >= cooldown)
        {
            WeaponType();
            timer.Counter = 0;

        }
    }
}
