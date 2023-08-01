using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RaycastWeapon : BaseWeapon
{
    private LineRenderer lineRenderer;
    private void Awake()
    {
        GetLineRenderer();
        SetWeaponFactory(new RaycastWeaponFactory(firePoint, lineRenderer, gunData.Forse));

        GetWeapon(gunData.TypeWeapon);
    }

    private void Update()
    {
         Shoot();
    }

    protected sealed override void Shoot()
    {
        if (isPlayerGun)
        {
            if (Input.GetButton("Fire1"))
            {
                WeaponType();
                
            }else lineRenderer.enabled = false;
        }
        else WeaponType();
    }

    private void GetLineRenderer()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
}
