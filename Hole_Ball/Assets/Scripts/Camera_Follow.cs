using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform ball;

    void FixedUpdate(){
        transform.position= new Vector3(ball.position.x, ball.position.y, transform.position.z);
    }
}
