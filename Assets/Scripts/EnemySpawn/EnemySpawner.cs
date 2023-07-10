using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySpawner : MonoBehaviour
{
    //[SerializeField] protected EnemyData enemyData;
    protected Timer timer = new Timer();
    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected int spawnDelay;
    protected ProjectilePool pool;
    [SerializeField] protected bool isAutoExtended;
    protected PoolMono<Rigidbody> poolMono;
    protected float spawnRange;
    [Header("Enemies")]
    //[SerializeField] protected List<Rigidbody> enemyPrefabs = new List<Rigidbody>();
    [SerializeField] protected EnemyData enemyData;
}
