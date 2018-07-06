using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public float movementSpeed;
    private Rigidbody rb;
    public float jumpForce;
    private bool onGround;


    // Use this for initialization
    void Awake()
    {
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
    void FixedUpdate()
    {

        if (TouchDetectors.rightButtomTouched || Input.GetKey(KeyCode.D))
        {
            MoveToRight();
        }
        if (TouchDetectors.leftButtomTouched || Input.GetKey(KeyCode.A))
        {
            MoveToLeft();
        }
        if (TouchDetectors.upButtomTouched || Input.GetKey(KeyCode.W))
        {
            MoveBackward();
        }
        if (TouchDetectors.downButtomTouched || Input.GetKey(KeyCode.S))
        {
            MoveForward();
        }
    }

    public void MoveToRight()
    {
        transform.position = transform.position + new Vector3(movementSpeed, 0, 0) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    public void MoveToLeft()
    {
        transform.position = transform.position + new Vector3(-movementSpeed, 0, 0) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, -90, 0);
    }

    public void MoveForward()
    {
        transform.position = transform.position + new Vector3(0, 0, -movementSpeed) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    public void MoveBackward()
    {
        transform.position = transform.position + new Vector3(0, 0, movementSpeed) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, 0);
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
