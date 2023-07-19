using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGunData : ScriptableObject
{
    [Header("Referenses to components")]
    [SerializeField] protected EnumAttack attack;
    public EnumAttack Attack => attack;
    
    [Header("Spawn parameters")]
    [SerializeField, Min(0)] private float forse;
    public float Forse => forse;

    [SerializeField, Min(0)] protected float cooldown;
    public float Cooldown => cooldown;

    public abstract void SetParametersInFactory(WeaponFactory gunFactory);
}
