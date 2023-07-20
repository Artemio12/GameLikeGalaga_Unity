using UnityEngine;

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

    [SerializeField, Min(0)] protected int poolEnemyCount;
    public int PoolEnemyCount => poolEnemyCount;

    [SerializeField] protected bool isAutoExpanded;
    public bool IsAutoExpanded => isAutoExpanded;

    protected void SetIsHorizontaledInFactory(BaseMovementFactory movementFactory) => movementFactory.IsHorisontaled = this.isHorizontaled;

    public abstract void SetParemeterInFactory(BaseMovementFactory movementFactory);
}
