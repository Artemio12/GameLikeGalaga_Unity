using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySpawner : MonoBehaviour
{
    protected Timer timer = new Timer();
    protected float spawnRange;

    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected int spawnDelay;
    [Header("Enemies")]
    [SerializeField] protected List<Rigidbody> enemyPrefabs = new List<Rigidbody>();
}
