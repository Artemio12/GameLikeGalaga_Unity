using UnityEngine;

public class PlayerWeapon : Weapon
{
    private bool isComponentGot;
    private void Awake()
    {
        SetFactory(new GunFactory(firePoint, firePoint.root, gunData.Forse)); // подача параметров в экземпляр класса фабрики
        gunData.SetParametersInFactory(weaponFactory);
        GetLineRenderer();
        GetGun(gunData.Attack);
    }

    private void LateUpdate()
    {
        if (isComponentGot) DoPlayerWeaponShoot();
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1")) DoPlayerWeaponShoot();
    }

    private void DoPlayerWeaponShoot()
    {
        WeaponType();
    }

    private void GetLineRenderer()
    {
        if (TryGetComponent<LineRenderer>(out LineRenderer component))
        {
            isComponentGot = true;
            weaponFactory.LineRenderer = component;
        }
    }
}
