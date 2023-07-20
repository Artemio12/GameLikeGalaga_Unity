using UnityEngine;

public class MineDamage : Damage
{
    [SerializeField] private float timeDestraction;

    private void Start()
    {
       // Destroy(gameObject,timeDestraction);
       
    }

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