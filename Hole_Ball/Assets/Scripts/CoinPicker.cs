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
            textCoins.text = coinsCollected.ToString();
            Destroy(col.gameObject);
        }

        if (col.transform.tag.Equals("Red"))
        {
            Destroy(this.gameObject);
            FindObjectOfType<GameManager>().EndGame(score: coinsCollected);
        }

    }


    public int getCoinsCollected()
    {
        return this.coinsCollected;
    }

}
