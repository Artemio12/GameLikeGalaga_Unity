using UnityEngine;

public class EnemyWeapon : Weapon
{
    private void Awake()
    {
        SetFactory(new GunFactory(firePoint, firePoint.root, gunData.Forse)); // ������ ���������� � ��������� ������ �������
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
