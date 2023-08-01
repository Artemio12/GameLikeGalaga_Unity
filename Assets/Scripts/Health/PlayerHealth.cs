using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private CameraShaker cameraShaker;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text textComponent;
    [SerializeField] private float playerHealth;

    private PanelActivator panel = new PanelActivator();

    private void Start()
    {
        UITextHP();
    }

    public override void TakeDamage(float damage)
    {
        cameraShaker.Shake();
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
        textComponent.text = "x" + playerHealth.ToString();
    }
}
