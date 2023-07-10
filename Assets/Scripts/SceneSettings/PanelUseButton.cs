using UnityEngine.SceneManagement;
using UnityEngine;

public class PanelUseButton : MonoBehaviour
{
    private PanelActivator activator = new PanelActivator();
    [SerializeField] private GameObject PausePanel;

    public void PauseButtonPressed()
    {
        activator.DoPanelActive(PausePanel);
    }

    public void ContinueButtonPressed()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitAppButtonPressed()
    {
        Application.Quit();
    }
   
}
