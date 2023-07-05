using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    private EnemyData enemyData;
    public void DoPlayerDamage(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<PlayerHealth>();
        health.TakeDamage(enemyData.ContactDamage);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DoPlayerDamage(other);
            Destroy(gameObject);
        }
    }
}
