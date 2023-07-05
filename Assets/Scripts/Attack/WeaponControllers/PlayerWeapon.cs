using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : Weapon
{
    private void Awake()
    {
        SetFactory(new GunWeaponFactory(firePoint, projectileData.ProjectileRigidbody, projectileData.Forse)); // ������ ���������� � ��������� ������ �������
        SetTypeGun(GetGun(attack)); // ������ �� ���������
    }

    private void FixedUpdate()
    {
        DoPlayerShoot();
    }

    private void DoPlayerShoot()
    {
        if (Input.GetButton("Fire1") && timer.TimeCount() >= cooldown)
        {
            timer.Counter = 0;
            WeaponType();
        }   
    }
}
