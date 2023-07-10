using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private ITypeShootable typeGun;
    protected ProjectilePool projectilePool;
    protected PoolMono<Rigidbody> poolMono;
    protected WeaponFactory weaponFactory;
    protected Timer timer = new Timer();

    [Header("Referenses to components")]
    [SerializeField] protected EnumAttack attack;
    [SerializeField] protected ProjectileData projectileData;
    [SerializeField] protected Transform projectileContainer;

    [SerializeField] protected Transform firePoint;
    public Transform FirePoint => firePoint;    

    [Header("Fight parameters")]
    [SerializeField] protected bool isAutoExpanded;
    [SerializeField, Min(0)] protected float cooldown;

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
