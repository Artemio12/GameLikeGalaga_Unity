using UnityEngine;

public class BulletDamage : Damage
{
    public void OnCollisionEnter(Collision other)
    {
        ReturnToPool();

        if (other.gameObject.TryGetComponent(out PlayerHealth playerHealth)) PlayerGetDamage(playerHealth);

        if (other.gameObject.TryGetComponent(out EnemyHealth enemyHealth))
        {
          enemyHealth.TakeDamage(contactDamage);
        }
    }
}
