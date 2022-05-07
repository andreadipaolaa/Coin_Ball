using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProdBallMovement : MonoBehaviour{
// {
// public bool isFlat= true;
//     private Rigidbody2D rigid;

//     // Start is called before the first frame update
//     private void Start()
//     {
//         rigid = GetComponent<Rigidbody2D>();
//     }

//     // Update is called once per frame
//     private void Update()
//     {
        
//         Vector3 tilt = Input.acceleration;

//         if(isFlat)
//             tilt= Quaternion.Euler(0,0,0)*tilt;


//         rigid.AddForce(tilt);
//         Debug.DrawRay(transform.position + Vector3.up, tilt, Color.green);

//     }
// }

    private Rigidbody2D rigid;
    private Vector2 movement;
    public float movementSpeed = 6f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
         movement = new Vector2(Input.acceleration.x , Input.acceleration.y) * movementSpeed;
         rigid.AddForce(movement);
    }
}