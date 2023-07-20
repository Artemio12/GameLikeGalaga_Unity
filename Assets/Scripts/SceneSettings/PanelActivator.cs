using UnityEngine;

public class PanelActivator 
{
    public void DoPanelActive(GameObject panel)
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
}
