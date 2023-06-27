using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damage : MonoBehaviour
{
    [SerializeField, Min(0)] protected float damage;

    protected void DoPlayerDamage(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<PlayerHealth>();
        health.TakeDamage(damage);
    }
}
