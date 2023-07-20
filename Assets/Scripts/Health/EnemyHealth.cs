using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField] private BaseEnemyData enemyData;
    private float maxEnemyHealth;
    private float currentHealth;

    private void Awake()
    {
        maxEnemyHealth = enemyData.EnemyHealth;
        currentHealth = maxEnemyHealth;
    }

    public override void TakeDamage(float damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, maxEnemyHealth);
        Debug.Log($"ХП врага {currentHealth}");

        if (currentHealth == 0f)
        {
            this.gameObject.SetActive(false);
            currentHealth = maxEnemyHealth;
        }
    }
}
