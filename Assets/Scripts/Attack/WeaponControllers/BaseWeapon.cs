using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    protected BaseWeaponFactory weaponFactory;
    private ITypeShootable typeGun;
    
    [Header("Referenses to components")]
    [SerializeField] protected BaseGunData gunData;
    [SerializeField] protected Transform firePoint;
    [SerializeField] protected bool isPlayerGun;

    protected void SetWeaponFactory(BaseWeaponFactory factory)
    {
        weaponFactory = factory;
        if (weaponFactory == null) 
        {
            Debug.LogError("Error: SetFactory(AttackFactory factory) returns attackFactory == null");
        }
    }
   
    protected void GetWeapon(EnumWeapon typeWeapon)
    {
        typeGun = this.weaponFactory.GetWeapon(typeWeapon); //получение нужного экземл€ра класса (из фабрики)
                                                      //и присваивание его переменной typeGun; 
        if (typeGun == null)
        {
            Debug.LogError("Error: GetWeapon(EnumAttack enumAttack) returns typeGun == null");
        }
    }

    protected void WeaponType()
    {
        typeGun.Attack();
    }

    protected abstract void Shoot();
}
