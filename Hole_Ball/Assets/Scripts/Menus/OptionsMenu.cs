using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void BackButton()
    {
        AudioManager.instance.Play("Click");
        SceneManager.LoadScene("MainMenu");
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        //AudioManager.instance.audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

}
