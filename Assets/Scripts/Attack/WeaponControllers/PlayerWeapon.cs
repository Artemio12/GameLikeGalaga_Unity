using UnityEngine;

public class PlayerWeapon : Weapon
{
    private void Awake()
    {
        projectilePool = new ProjectilePool(isAutoExpanded);
        poolMono = projectilePool.CreateObjectsInPool(projectileContainer, projectileData.ProjectileRigidbody, projectileData.PoolCount);

        SetFactory(new GunWeaponFactory(firePoint, poolMono, projectileData.Forse)); // подача параметров в экземпл€р класса фабрики
        SetTypeGun(GetGun(attack)); // ссылка на интерфейс
    }

    private void FixedUpdate()
    {       
        DoPlayerWeaponShoot();  
    }

    private void DoPlayerWeaponShoot()
    {
        if (Input.GetButton("Fire1") && timer.TimeCount() >= cooldown)
        {
            WeaponType();
            timer.Counter = 0;
        }
    }
}
