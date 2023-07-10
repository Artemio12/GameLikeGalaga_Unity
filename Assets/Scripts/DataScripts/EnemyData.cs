using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/Enemies/Mobs")]
public class EnemyData : ScriptableObject
{
    [Header("Base parameters")]
    [SerializeField] private string enemyName;
    public string EnemyName => enemyName;

    [SerializeField,Min(0)] private float enemyHealth;
    public float EnemyHealth => enemyHealth;

    //[SerializeField,Min(0)] private int contactDamage = 1;
    //public int ContactDamage => contactDamage;

    [SerializeField,Min(0)] private int enemyDeathPoints;
    public int EnemyDeathPoints => enemyDeathPoints;

    [Header("Movement parameters")]
    [SerializeField] private EnumMovement movement;
    public EnumMovement Movement => movement;

    [SerializeField,Min(0)] private float enemySpeed ;
    public float EnemySpeed => enemySpeed;

    [SerializeField] private bool isHorizontaled;
    public bool IsHorizontaled => isHorizontaled;

    [SerializeField] private bool isReversed;
    public bool IsReversed => isReversed;

    [Header("Spawn parameters")]
    [SerializeField, Min(0)] private int poolCount;
    public int PoolCount => poolCount;

    [SerializeField] private Rigidbody enemyRigidbody;
    public Rigidbody EnemyRigidbody => enemyRigidbody;
}
