using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text points;
    public Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }


    public void EndGame(int score)
    {
        Debug.Log("entrato in end game");
        Debug.Log(score);
        points.text = score.ToString();
        if (PlayerPrefs.GetInt("Highscore", 0 ) < score)
        {
            PlayerPrefs.SetInt("Highscore", score);
            highScore.text = score.ToString();
        }
        SceneManager.LoadScene("LoseScreen");
    }
}
