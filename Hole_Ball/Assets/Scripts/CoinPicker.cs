using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private float coinsCollected = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag.Equals("Coin"))
        {
            coinsCollected++;
            textCoins.text = coinsCollected.ToString();
            Destroy(col.gameObject);
        }
    }
}
