using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenuUI;


    public void PauseBottone()
    {
        if (isPaused)
            Resume();
        else
            Pause();
    }

    private void Pause()
    {
        AudioManager.instance.Play("Click");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Resume()
    {
        AudioManager.instance.Play("Click");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void HomeButton()
    {
        AudioManager.instance.Play("Click");
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        isPaused = false;
    }

    /*public void OptionsButton()
    {
        AudioManager.instance.Play("Click");
        SceneManager.LoadScene("OptionsScene");
    }*/

}
