using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private ITypeShootable typeGun;
    protected WeaponFactory weaponFactory;

    [Header("Referenses to components")]
    [SerializeField] protected BaseGunData gunData;
    [SerializeField] protected Transform firePoint;
     public Transform FirePoint => firePoint;    

    protected void SetFactory(WeaponFactory factory)
    {
        weaponFactory = factory;
        if (weaponFactory == null) 
        {
            Debug.LogError("Error: SetFactory(AttackFactory factory) returns attackFactory == null");
        }
    }
   
    protected void GetGun(EnumAttack enumAttack)
    {
        typeGun = weaponFactory.GetWeapon(enumAttack); //получение нужного экземл€ра класса (из фабрики)
                                                      //и присваивание его переменной typeGun; 
        if (typeGun == null)
        {
            Debug.LogError("Error: GetGun(EnumAttack enumAttack) returns typeGun == null");
        }
    }

    protected void WeaponType()
    {
        typeGun.Attack();
    }
}
