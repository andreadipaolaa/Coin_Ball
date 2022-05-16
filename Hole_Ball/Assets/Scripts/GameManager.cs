using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text points; 

    //bool gameHasEnded = false;
    public void EndGame(int score)
    {
        points.text = score.ToString() + " POINTS";
        SceneManager.LoadScene("LoseScreen");
    }
}
