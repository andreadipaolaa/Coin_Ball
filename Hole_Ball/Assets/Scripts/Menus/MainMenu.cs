using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject signInButton;

    private static bool isLogged = false;

    private void Start()
    {
        if (isLogged)
            disableSignInButton();
    }

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

    public void SignInButton()
    {
        AudioManager.instance.Play("Click");
        isLogged = true;
        SceneManager.LoadScene("Auth");
    }

    public void disableSignInButton()
    {
        signInButton.SetActive(false);
    }

}
