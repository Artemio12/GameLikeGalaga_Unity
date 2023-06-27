using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamage : Damage
{
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DoPlayerDamage(other);
            Destroy(gameObject);
        }
    }
}
