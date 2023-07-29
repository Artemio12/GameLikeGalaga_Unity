using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySpawner : MonoBehaviour
{
    [Header("Spawn parameters")]
    [SerializeField] protected BaseEnemyData enemyData;
    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected Transform enemyContainer;
    [Space]
    [SerializeField] protected int spawnDelay;
    //[Space]
    //[SerializeField] protected List<BaseEnemyData> enemyDataList = new List<BaseEnemyData>();

    protected Timer timer = new Timer();
    protected PoolObjects<Rigidbody> pool;
    protected float spawnRange;

    protected void CreateEnemyPool(Transform container)
    {
        pool = new PoolObjects<Rigidbody>(enemyContainer, enemyData.Rigidbody, enemyData.PoolCount);
        pool.AutoExpand = enemyData.IsAutoExpanded;
    }
}
