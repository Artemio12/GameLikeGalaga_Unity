using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDamage : Damage
{
    private Explosion explosion;
    [SerializeField] private float radius;
    private void Start()
    {
        explosion = new Explosion(this.transform, radius);
    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }

    private void OnCollisionEnter(Collision other)
    {
        ReturnToPool();
      //  explosion = new Explosion(this.transform, radius);
        if (other.gameObject.CompareTag("Enemy"))
        { 
            explosion.Attack();
        }
    }
}
