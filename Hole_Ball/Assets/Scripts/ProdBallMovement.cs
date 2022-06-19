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
    //private Vector2 movement;
    public float movementSpeed = 1;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

   /*  void Update()
    {
         movement = new Vector2(Input.acceleration.x , Input.acceleration.y) * movementSpeed;
         rigid.AddForce(movement);

    } */

   private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float movementX = touch.position.x;
            float movementY = touch.position.y;
            // Just so you know: Note that ScreenToWorldPoint takes a Vector3 where the 
            // Z component is the distance in front of the camera
            // currently you are passing in 0 so the object will move in the same plane
            // as the camera
            rigid.position = Vector3.MoveTowards(rigid.position, new Vector3(movementX,movementY,0f), movementSpeed * Time.deltaTime);
        }
    }
}