using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : Health
{
    [SerializeField] private BaseEnemyData enemyData;
    private float fullEnemyHealth;
    private float currentHealth;

    private void Awake()
    {
        fullEnemyHealth = enemyData.EnemyHealth;
        currentHealth = fullEnemyHealth;
    }

    public override void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log($"ХП врага {currentHealth}");
        if (currentHealth <= 0f)
        {
            this.gameObject.SetActive(false);
            currentHealth = fullEnemyHealth;
        }
    }
}
