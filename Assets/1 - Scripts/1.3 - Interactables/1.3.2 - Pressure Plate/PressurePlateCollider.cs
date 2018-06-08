using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateCollider : MonoBehaviour {

    public bool isPressed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Player")|| (collision.gameObject.tag == "Box"))
        {
            isPressed = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if ((collision.gameObject.tag == "Player") || (collision.gameObject.tag == "Box"))
        {
            isPressed = false;
        }
    }
}
