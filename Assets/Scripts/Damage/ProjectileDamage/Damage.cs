using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damage : MonoBehaviour
{
    [SerializeField] protected ProjectileData projectileData;
    protected ContactDamager contactDamager;
}
