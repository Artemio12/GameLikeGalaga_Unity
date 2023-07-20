using UnityEngine;

[CreateAssetMenu(fileName = "GunData_default", menuName = "GameData/Guns/DefaultGun")]
public class DefaultGunData : BaseGunWithPoolData
{
    private BaseGunData baseGun;

    public DefaultGunData(BaseGunData baseGun)
    {
        this.baseGun = baseGun;
    }

    public override void SetParametersInFactory(WeaponFactory gunFactory)
    {
        gunFactory.Cooldown = cooldown;
        gunFactory.Projectile = projectile.ProjectileRigidbody;
        gunFactory.PoolCount = poolCount;
        gunFactory.IsAutoExpanded = IsAutoExpanded;
    }

}
