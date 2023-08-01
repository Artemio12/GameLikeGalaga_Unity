using UnityEngine;

public class DefaulShootGun : ITypeShootable
{
    private PoolObjects<Rigidbody> poolMono;
    private Transform firePoint;
    private float bulletForse;
    private float cooldown;

    private Timer timer = new Timer();
  
    public DefaulShootGun(Transform firePoint, PoolObjects<Rigidbody> poolMono, float bulletForse, float cooldown)
    {
        this.firePoint = firePoint;
        this.poolMono = poolMono;
        this.bulletForse = bulletForse;
        this.cooldown = cooldown;
    }

    public void Attack()
    {
        if (timer.TimeCount() >= cooldown)
        {
            var projectile = poolMono.GetFreeElement(firePoint.position);
            projectile.velocity = firePoint.up * bulletForse;
            timer.Counter = 0f;
        }
    }
}
