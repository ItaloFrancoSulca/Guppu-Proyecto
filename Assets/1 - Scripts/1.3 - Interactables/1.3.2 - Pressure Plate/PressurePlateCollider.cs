using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateCollider : MonoBehaviour {

    static public bool isPressed;

	// Use this for initialization
	void Start () {
		isPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider collision)
    {
        if ((collision.gameObject.tag == "Player")|| (collision.gameObject.tag == "Box"))
        {
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if ((collision.gameObject.tag == "Player") || (collision.gameObject.tag == "Box"))
        {
            isPressed = false;
        }
    }
}
