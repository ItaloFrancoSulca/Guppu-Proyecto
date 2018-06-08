using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {

    public float movementSpeed;
    private Rigidbody rb;
    public float jumpForce;
    private bool onGround;
    

    // Use this for initialization
    void Awake () {
        rb = GetComponent<Rigidbody>();
	}


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.velocity = new Vector3(0, jumpForce, 0);
        }
    }


    // Update is called once per frame
    void FixedUpdate () {
        
		if (TouchDetectors.rightButtomTouched)
        {
            MoveToRight();
        }
        if (TouchDetectors.leftButtomTouched)
        {
            MoveToLeft();
        }
        if (TouchDetectors.upButtomTouched)
        {
            MoveBackward();
        }
        if (TouchDetectors.downButtomTouched)
        {
            MoveForward();
        }
    }

    public void MoveToRight()
    {
        transform.position = transform.position + new Vector3(movementSpeed, 0, 0) * Time.deltaTime;
    }

    public void MoveToLeft()
    {
        transform.position = transform.position + new Vector3(-movementSpeed, 0, 0) * Time.deltaTime;
    }

    public void MoveForward()
    {
        transform.position = transform.position + new Vector3(0, 0, -movementSpeed) * Time.deltaTime;
    }

    public void MoveBackward()
    {
        transform.position = transform.position + new Vector3(0, 0, movementSpeed) * Time.deltaTime;
    }

    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}
