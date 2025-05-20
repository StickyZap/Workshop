using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuButtonComp : MonoBehaviour
{
    public void OnPressMainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
