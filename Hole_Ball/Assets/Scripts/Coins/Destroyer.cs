using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    private float lifeTime;

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime<0)
            Object.Destroy(this.gameObject);
    }


}
