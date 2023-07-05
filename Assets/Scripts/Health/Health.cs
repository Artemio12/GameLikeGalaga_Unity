using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    //[SerializeField, Min(0)] protected float health;
    public abstract void TakeDamage(float damage);  
}
