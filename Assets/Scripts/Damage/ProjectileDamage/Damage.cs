using UnityEngine;

public abstract class Damage : MonoBehaviour
{
    protected int contactDamage = 1;
    public void PlayerGetDamage(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<PlayerHealth>();
        health.TakeDamage(contactDamage);
    }
    public void ReturnToPool()
    {
        this.gameObject.SetActive(false);
    }
}
