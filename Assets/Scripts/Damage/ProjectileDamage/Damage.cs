using UnityEngine;

public abstract class Damage : MonoBehaviour
{
    protected int contactDamage = 1;
    public void PlayerGetDamage(Health playerHealth)
    {
        playerHealth.TakeDamage(contactDamage);
    }
    public void ReturnToPool()
    {
        this.gameObject.SetActive(false);
    }
}
