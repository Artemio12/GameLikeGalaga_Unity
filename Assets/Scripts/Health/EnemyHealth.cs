using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : Health
{
    // private ScoreCounter scoreCounter = new ScoreCounter();

    [SerializeField,Min (0)] private int enemyScore;

    public override void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Значение " + health);
        if (health <= 0) Destroy(gameObject);
    }
}
