using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySpawner : MonoBehaviour
{
    [Header("Spawn parameters")]
    [SerializeField] protected BaseEnemyData enemyData;
    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected Transform enemyContainer;

    [SerializeField] protected int spawnDelay;

    protected PoolObjects<Rigidbody> poolMono;
    protected Timer timer = new Timer();
    protected float spawnRange;

    protected void CreateEnemyPool(Transform container)
    {
        PoolCreator pool = new PoolCreator(enemyData.EnemyRigidbody, enemyData.IsAutoExpanded, enemyData.PoolEnemyCount);
        poolMono = pool.CreatePoolWithObjects(container);
    }

    //[SerializeField] protected List<Rigidbody> enemyPrefabs = new List<Rigidbody>();
}
