using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : Health
{
    //private ReturnerToPool returner;
    [SerializeField] private EnemyData enemyData;
    // private ScoreCounter scoreCounter = new ScoreCounter();
    private float enemyHealth;
    private int enemyDeathPoints;

    private void Awake()
    {
        enemyHealth = enemyData.EnemyHealth;
        enemyDeathPoints = enemyData.EnemyDeathPoints;
    }

    public override void TakeDamage(float damage)
    {
        enemyHealth -= damage;
        Debug.Log("Значение " + enemyHealth);
        if (enemyHealth <= 0) this.gameObject.SetActive(false);//this.returner.ReturnToPool();
    }
}
