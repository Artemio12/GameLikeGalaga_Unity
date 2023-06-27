using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : Weapon
{
   // [SerializeField, Min(0)] private int enemyScore;
  //  public int EnemyScore => enemyScore;

    private void Awake()
    {
        SetFactory(new GunWeaponFactory(firePoint, progectilePrefub, forse)); // подача параметров в экземпл€р класса фабрики
        SetTypeGun(GetGun(playerAttack)); // ссылка на интерфейс
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
