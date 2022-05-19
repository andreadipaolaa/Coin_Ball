using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        AudioManager.instance.Play("Click");
        SceneManager.LoadScene("SampleScene");
    }

    public void OptionsButton()
    {
        AudioManager.instance.Play("Click");
        SceneManager.LoadScene("OptionsMenu");
    }

    public void QuitButton()
    {
        AudioManager.instance.Play("Click");
        Application.Quit();
    }

}
