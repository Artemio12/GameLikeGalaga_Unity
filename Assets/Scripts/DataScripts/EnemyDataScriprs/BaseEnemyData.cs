using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/Enemies/PatrulBoat", order = 51)]
public abstract class BaseEnemyData : ScriptableObject
{
    [Header("Base parameters")]
    [SerializeField] protected string enemyName;
    public string EnemyName => enemyName;

    [SerializeField, Min(0)] protected float enemyHealth;
    public float EnemyHealth => enemyHealth;

    //[SerializeField,Min(0)] private int contactDamage = 1;
    //public int ContactDamage => contactDamage;

    [SerializeField, Min(0)] protected int enemyDeathPoints;
    public int EnemyDeathPoints => enemyDeathPoints;

    [Header("Movement parameters")]
    [SerializeField] protected EnumMovement movement;
    public EnumMovement Movement => movement;

    [SerializeField, Min(0)] protected float enemySpeed;
    public float EnemySpeed => enemySpeed;

    [SerializeField] protected bool isHorizontaled;

    public bool IsHorizontaled => isHorizontaled;

    [SerializeField] protected bool isReversed;
    public bool IsReversed => isReversed;

    [Header("Spawn parameters")]
    [SerializeField] protected Rigidbody enemyRigidbody;
    public Rigidbody EnemyRigidbody => enemyRigidbody;

    [SerializeField, Min(0)] protected int poolCount;
    public int PoolCount => poolCount;

    [SerializeField] protected bool isAutoExpanded;
    public bool IsAutoExpanded => isAutoExpanded;

    protected void SetIsHorizontaledInFactory(SimpleMovementFactory movementFactory) => movementFactory.IsHorisontaled = this.isHorizontaled;

    public abstract void SetParemeterInFactory(SimpleMovementFactory movementFactory);
}
