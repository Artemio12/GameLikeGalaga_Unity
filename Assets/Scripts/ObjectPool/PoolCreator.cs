using UnityEngine;

public class PoolCreator 
{
    // private BaseGunWithPoolData gunData;
    private Rigidbody projectile;
    private bool isAutoExpanded;
    private int poolCount;

    public PoolCreator(Rigidbody projectile, bool isAutoExpanded, int poolCount )
    {
        this.projectile = projectile;
        this.isAutoExpanded = isAutoExpanded;
        this.poolCount = poolCount; 
    }

    public PoolObjects<Rigidbody> CreatePoolWithObjects(Transform container)
    {
        PoolObjects<Rigidbody> poolMono = new PoolObjects<Rigidbody>(container, projectile, poolCount);
        poolMono.AutoExpand = isAutoExpanded;
        return poolMono;
    }
}
