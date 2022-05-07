using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class PlayerMovement : MonoBehaviour
{
public bool isFlat= true;
    private Rigidbody2D rigid;

    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        Vector3 tilt = Input.acceleration;

        if(isFlat)
            tilt= Quaternion.Euler(0,0,0)*tilt;


        rigid.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.green);

    }



} // class*/


public class DevPlayerMovement : MonoBehaviour
{
    public float moveForce = 10f;
    private float movementX;
    private float movementY;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();

    }

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(movementX, movementY, 0f) * moveForce * Time.deltaTime;
    }

}
