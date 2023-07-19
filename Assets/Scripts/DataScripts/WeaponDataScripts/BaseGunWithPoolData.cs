using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGunWithPoolData : BaseGunData
{
    [Header("Spawn parameters")]
    [SerializeField] protected ProjectileData projectile;
    public ProjectileData Projectile => projectile;

    [SerializeField, Min(0)] protected int poolCount;
    public int PoolCount => poolCount;

    [SerializeField] protected bool isAutoExpanded;
    public bool IsAutoExpanded => isAutoExpanded;
}
