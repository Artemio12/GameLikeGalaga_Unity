using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemySpawner : EnemySpawner
{
    private void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (timer.TimeCount() >= spawnDelay)
        {
            spawnRange = Random.Range(-2, 2);
            Vector3 spawnArea = new Vector3(spawnRange, spawnPoint.position.y);
            int i = Random.Range(0, enemyPrefabs.Count);
            var enemy = GameObject.Instantiate(enemyPrefabs[i], spawnArea, Quaternion.identity);
            i = 0;
            timer.Counter = 0;
        }
    }
}
