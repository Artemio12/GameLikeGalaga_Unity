using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunData_laser", menuName = "GameData/Guns/LaserGun")]
public class LaserGunData : BaseGunWithRaycastData
{
    public override void SetParametersInFactory(WeaponFactory gunFactory)
    {

       // LineRenderer.enabled = false;
       // gunFactory.LineRenderer = LineRenderer;
       
    }
}
