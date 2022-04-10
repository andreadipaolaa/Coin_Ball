using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    //public Text points;

    /*public void Setup(int score)
    {
        gameObject.SetActive(true);
        points.text = score.ToString() + " POINTS";
    }*/

    public void ReplayButton ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    /*public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }*/
}
