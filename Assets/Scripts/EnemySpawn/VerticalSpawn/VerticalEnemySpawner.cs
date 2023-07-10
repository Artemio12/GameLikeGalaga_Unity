using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemySpawner : EnemySpawner
{
    [SerializeField] private Transform enemyContainer;
    private void Start()
    {
        pool = new ProjectilePool(isAutoExtended);
        poolMono = pool.CreateObjectsInPool(enemyContainer, enemyData.EnemyRigidbody, enemyData.PoolCount);
    }

    private void FixedUpdate()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (timer.TimeCount() >= spawnDelay)
        {
            spawnRange = Random.Range(-2, 2);
            Vector3 spawnArea = new Vector3(spawnRange, spawnPoint.position.y);
            // int i = Random.Range(0, enemyPrefabs.Count);
            //var enemy = GameObject.Instantiate(enemyData.EnemyRigidbody, spawnArea, Quaternion.identity);
            var enemy = this.poolMono.GetFreeElement(spawnArea);
            //i = 0;
            timer.Counter = 0;
        }
    }
}
