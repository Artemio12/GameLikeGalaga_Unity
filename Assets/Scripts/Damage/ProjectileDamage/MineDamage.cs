using UnityEngine;

public class MineDamage : Damage
{
    [SerializeField] private float timeDestraction;

    private void Start()
    {
       
    }

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