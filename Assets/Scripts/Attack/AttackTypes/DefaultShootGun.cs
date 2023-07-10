using UnityEngine;

public class DefaulShootGun : ITypeShootable
{
    private PoolMono<Rigidbody> poolMono;
    private Transform firePoint;
    private float bulletForse;
  
    public DefaulShootGun(Transform firePoint, PoolMono<Rigidbody> poolMono , float bulletForse)
    {
        this.firePoint = firePoint;
        this.poolMono = poolMono;
        this.bulletForse = bulletForse;
    }

    public void Attack()
    {
        var projectile = poolMono.GetFreeElement(firePoint.position);
        projectile.velocity = firePoint.up * bulletForse;
    }
}
