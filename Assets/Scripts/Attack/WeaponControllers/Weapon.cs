using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour 
{
    [Header("Referenses to components")]
    [SerializeField] protected EnumAttack attack;
    [SerializeField] protected ProjectileData projectileData;
    [SerializeField] protected Transform firePoint;
    [Header("Fight parameters")]
    [SerializeField, Min(0)] protected float cooldown;

    protected WeaponFactory weaponFactory;
    private ITypeShootable typeGun;

    protected Timer timer = new Timer();

    protected void SetFactory(WeaponFactory factory)
    {
        weaponFactory = factory;
        if (weaponFactory == null) 
        {
            Debug.LogError("Error: SetFactory(AttackFactory factory) returns attackFactory == null");
        }
    }
    protected void SetTypeGun(ITypeShootable attack)
    {
        typeGun = attack;
        if (typeGun == null)
        {
            Debug.LogError("Error: SetTypeAttack(ITypeAttack attack) returns typeAttack == null");
        }
    }

    protected ITypeShootable GetGun(EnumAttack enumAttack)
    {
        ITypeShootable typeAttack = weaponFactory.CreateGun(enumAttack); //получение нужного экземл€ра класса (из фабрики)
                                                                         //и присваивание его переменной typeAttack; 
        if (typeAttack == null)
        {
            Debug.LogError("Error: GetAttack(EnumAttack enumAttack) returns typeAttack == null");
        }
        return typeAttack;
    }

    protected void WeaponType()
    {
        typeGun.Attack();
    }
}
