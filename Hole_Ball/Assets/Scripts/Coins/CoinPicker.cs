using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private int coinsCollected = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag.Equals("Coin"))
        {
            coinsCollected++;
            AudioManager.instance.Play("Coins");
            textCoins.text = coinsCollected.ToString();
            Destroy(col.gameObject);
        }

        if (col.transform.tag.Equals("Red"))
        {
            Destroy(this.gameObject);
            AudioManager.instance.Play("GameOver");
            FindObjectOfType<GameManager>().EndGame(coinsCollected);
        }

        if (col.transform.tag.Equals("Wall"))
        {
            AudioManager.instance.Play("Wall");
            Debug.Log("collision happened");
        }

    }


    public int getCoinsCollected()
    {
        return this.coinsCollected;
    }

}
