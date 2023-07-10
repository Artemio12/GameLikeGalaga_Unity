using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePool 
{
    private bool autoExpand;

    public ProjectilePool(bool isAutoExpanded)
    {
        this.autoExpand = isAutoExpanded;
    }

    public PoolMono<Rigidbody> CreateObjectsInPool(Transform container, Rigidbody rigidbody, int poolCount)
    {
        PoolMono<Rigidbody> poolMono = new PoolMono<Rigidbody>(container, rigidbody, poolCount);
        poolMono.AutoExpand = this.autoExpand;
        return poolMono;
    }
}
