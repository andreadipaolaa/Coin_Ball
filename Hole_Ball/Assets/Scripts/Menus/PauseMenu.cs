using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;

    public GameObject pauseMenuUI;

    public GameObject pauseButton;

    public GameObject joystick;


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
        pauseButton.SetActive(false);
        joystick.SetActive(false);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Resume()
    {
        AudioManager.instance.Play("Click");
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        joystick.SetActive(true);
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


}
