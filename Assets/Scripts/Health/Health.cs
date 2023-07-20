using UnityEngine;

public abstract class Health : MonoBehaviour
{
    //[SerializeField, Min(0)] protected float health;

    public abstract void TakeDamage(float damage);  
}
