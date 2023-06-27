using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    [SerializeField] private Text textComponent;

    private void Start()
    {
        UITextHP();
    }

    public override void TakeDamage(float damage)
    {
        health -= damage;
        UITextHP();
        Debug.Log("Значение " + health);
        if (health <= 0) Destroy(gameObject);
    }

    private void UITextHP()
    {
        if (gameObject.CompareTag("Player")) textComponent.text = "x" + health.ToString();
    }
}
