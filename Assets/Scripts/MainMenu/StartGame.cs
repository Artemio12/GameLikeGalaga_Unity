using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void StartLevel(int namberScene)
    {
        SceneManager.LoadScene(namberScene);
    }
}
