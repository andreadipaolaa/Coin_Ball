using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{



    public void ReplayButton ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
