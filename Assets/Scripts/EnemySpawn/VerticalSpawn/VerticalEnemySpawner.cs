using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemySpawner : EnemySpawner
{
    
    private void Start()
    {
        CreateEnemyPool(enemyContainer);
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
            var enemy = this.poolMono.GetFreeElement(spawnArea);
            //i = 0;
            timer.Counter = 0;
        }
    }
}
