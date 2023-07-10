using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    [SerializeField] private float playerHealth;
    [SerializeField] private Text textComponent;
    [SerializeField] private GameObject gameOverPanel;
    private PanelActivator panel = new PanelActivator();

    private void Start()
    {
        UITextHP();
    }

    public override void TakeDamage(float damage)
    {
        playerHealth -= damage;
        UITextHP();
        Debug.Log("Значение " + playerHealth);
        if (playerHealth <= 0)
        {
            gameObject.SetActive(false);
            panel.DoPanelActive(gameOverPanel);
        }
    }

    private void UITextHP()
    {
        if (gameObject.CompareTag("Player")) textComponent.text = "x" + playerHealth.ToString();
    }
}
