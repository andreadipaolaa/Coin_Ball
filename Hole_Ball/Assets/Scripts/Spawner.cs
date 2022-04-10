using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] coins;
    [SerializeField]
    private Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    private int randCoin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawner());
        StartCoroutine(waitDestroyer());

    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    /* it spwans yellow coins and red coins*/
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randCoin = Random.Range(0, 2);
            Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), 1);
            Instantiate(coins[randCoin], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }


    /* it destroys yellow coins and red coins after 10 seconds */
    IEnumerator waitDestroyer()
    {
        yield return new WaitForSeconds(10);
        Object.Destroy(this.gameObject);
    }
}
