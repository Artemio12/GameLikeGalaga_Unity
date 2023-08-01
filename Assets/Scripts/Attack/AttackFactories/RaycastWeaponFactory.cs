using UnityEngine;

public class RaycastWeaponFactory : BaseWeaponFactory
{
    private LineRenderer lineRenderer;
    public RaycastWeaponFactory(Transform firePoint, LineRenderer lineRenderer, float forse ): base(firePoint, forse)
    {
        this.lineRenderer = lineRenderer;
    }
    protected sealed override ITypeShootable CreateGun(EnumWeapon typeWeapon)
    {
        ITypeShootable weapon = null;
        switch (typeWeapon)
        {
            case EnumWeapon.None:
                Debug.LogError("typeWeapon not selected");
                break;
            case EnumWeapon.Laser:
                weapon = new LaserGun(firePoint, lineRenderer, forse);
                break;
            default:
                Debug.LogError($"{typeWeapon} doesn't exist in RaycastWeaponFactory");
                break;
        }
        return weapon;
    }
}
