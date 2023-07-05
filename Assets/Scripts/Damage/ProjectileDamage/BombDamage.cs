using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamage : Damage
{
    [SerializeField] private float timeDestraction;

    private void Start()
    {
        Destroy(gameObject,timeDestraction);
    }

    public void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);

        if (other.gameObject.CompareTag("Player")) contactDamager.DoPlayerDamage(other);

        if (other.gameObject.CompareTag("Enemy"))
        {
            Health health = other.gameObject.GetComponent<EnemyHealth>();
            health.TakeDamage(projectileData.Damage);
        }
    }
}