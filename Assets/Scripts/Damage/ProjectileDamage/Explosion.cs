using UnityEngine;

public class Explosion : ITypeShootable
{
    private float radiusExplosion;
    private float forseExplosion = 10f;
    private float damage = 2f;
    private Transform centerExplosion;

    public Explosion(Transform centerExplosion, float radiusExplosion)
    {
        this.centerExplosion = centerExplosion;
         this.radiusExplosion = radiusExplosion;
    }

    public void Attack()
    {
        // массив коллайдеров в сфере с центров в transform.position и радиусом radiusExplosion  
        Collider[] collider = Physics.OverlapSphere(centerExplosion.position, radiusExplosion);
        for (int i = 0; i < collider.Length; i++)
        {
            if (collider[i].TryGetComponent(out Rigidbody rb))
            {
                rb.AddExplosionForce(forseExplosion, centerExplosion.position, radiusExplosion);
            }
            if (collider[i].TryGetComponent(out Health health))
            {
                health.TakeDamage(damage);
            }
        }
    }
}
