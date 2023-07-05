using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : Weapon
{
    private void Awake()
    {
        SetFactory(new GunWeaponFactory(firePoint, projectileData.ProjectileRigidbody, projectileData.Forse)); // ������ ���������� � ��������� ������ �������
        SetTypeGun(GetGun(attack)); // ������ �� ���������
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
