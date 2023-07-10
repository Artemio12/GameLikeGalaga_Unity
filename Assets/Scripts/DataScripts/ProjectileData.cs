using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "GameData/Projectile")]
public class ProjectileData : ScriptableObject
{
    [Header("Base parameters")]
    [SerializeField] private string projectileName;
    public string ProjectileName => projectileName;

    

    //[SerializeField, Min(0)] private int damage;
    //public int Damage => damage;

    [Header("Spawn parameters")]
    [SerializeField,Min (0)] private float forse;
    public float Forse => forse;

    [SerializeField,Min (0)] private int poolCount;
    public int PoolCount => poolCount;  

    [SerializeField] private Rigidbody projectileRigidbody;
    public Rigidbody ProjectileRigidbody => projectileRigidbody;
}
