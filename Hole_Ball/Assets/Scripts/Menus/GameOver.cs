using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{



    public void ReplayButton ()
    {
        AudioManager.instance.Play("Click");
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenuButton()
    {
        AudioManager.instance.Play("Click");
        SceneManager.LoadScene("MainMenu");
    }
}
