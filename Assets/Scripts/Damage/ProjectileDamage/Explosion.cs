using UnityEngine;

public class Explosion
{
    private Transform centerExplosion;
    private float radiusExplosion;
    private float forseExplosion = 15f;
    private float damage = 2f;
    
    public Explosion(Transform centerExplosion, float radiusExplosion)
    {
        this.centerExplosion = centerExplosion;
        this.radiusExplosion = radiusExplosion;
    }

    public void Attack()
    {
        // массив коллайдеров в сфере с центров в transform.position и радиусом radiusExplosion  
        Collider[] colliders = Physics.OverlapSphere(centerExplosion.position, radiusExplosion);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].TryGetComponent(out Rigidbody rb))
            {
                Vector3 direction = (colliders[i].transform.position - centerExplosion.position).normalized;
                rb.AddForce(direction * forseExplosion, ForceMode.Impulse);
            }
            if (colliders[i].TryGetComponent(out EnemyHealth health))
            {
                health.TakeDamage(damage);
            }
        }
    }
}
