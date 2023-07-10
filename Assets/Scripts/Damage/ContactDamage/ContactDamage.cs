using UnityEngine;

public class ContactDamage : Damage
{   
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ReturnToPool();
            PlayerGetDamage(other);
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            ReturnToPool();
        }
    }
}
