using UnityEngine;

public abstract class BaseGunData : ScriptableObject
{
    [Header("Referenses to components")]
    [SerializeField] protected EnumWeapon typeWeapon;
    public EnumWeapon TypeWeapon => typeWeapon;
    
    [Header("Spawn parameters")]
    [SerializeField, Min(0)] private float forse;
    public float Forse => forse;

    [SerializeField, Min(0)] protected float cooldown;
    public float Cooldown => cooldown;

    public abstract void SetParametersInFactory(BaseWeaponFactory gunFactory);
}
