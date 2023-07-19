using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySpawner : MonoBehaviour
{
    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected int spawnDelay;
    //[SerializeField] protected bool isAutoExpanded;
    [Header("Enemies")]
    [SerializeField] protected BaseEnemyData enemyData;
    [SerializeField] protected Transform enemyContainer;

    protected Timer timer = new Timer();
    //protected PoolCreator pool;
    protected PoolObjects<Rigidbody> poolMono;
    protected float spawnRange;

    protected void CreateEnemyPool(Transform container)
    {
        PoolCreator pool = new PoolCreator(enemyData.EnemyRigidbody, enemyData.IsAutoExpanded, enemyData.PoolCount);
        poolMono = pool.CreatePoolWithObjects(container);
    }

    //[SerializeField] protected List<Rigidbody> enemyPrefabs = new List<Rigidbody>();
}
