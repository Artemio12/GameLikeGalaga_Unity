using UnityEngine;

public class ContactDamage : Damage
{   
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out PlayerHealth playerHealth))
        {
            ReturnToPool();
            PlayerGetDamage(playerHealth);
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            ReturnToPool();
        }
    }
}
