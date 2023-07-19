using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : Damage
{
    public void OnCollisionEnter(Collision other)
    {
        ReturnToPool();

        if (other.gameObject.CompareTag("Player")) PlayerGetDamage(other);

        if (other.gameObject.CompareTag("Enemy"))
        {
          Health health = other.gameObject.GetComponent<EnemyHealth>();
          health.TakeDamage(contactDamage);
        }
    }
}
