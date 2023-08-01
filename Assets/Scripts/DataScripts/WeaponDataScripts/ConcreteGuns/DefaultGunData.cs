using UnityEngine;

[CreateAssetMenu(fileName = "DefaultBulletGun", menuName = "GameData/Guns/DefaultBulletGun")]
public class DefaultGunData : BaseGunWithPoolData
{
    private BaseGunData baseGun;

    public DefaultGunData(BaseGunData baseGun)
    {
        this.baseGun = baseGun;
    }

    public override void SetParametersInFactory(BaseWeaponFactory weaponFactory)
    {
        weaponFactory.Cooldown = cooldown;
        weaponFactory.Projectile = projectile.ProjectileRigidbody;
        weaponFactory.PoolCount = poolCount;
        weaponFactory.IsAutoExpanded = IsAutoExpanded;
    }

}
