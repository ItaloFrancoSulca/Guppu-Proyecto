using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {

    public bool isAbleSwitch;
    public bool switching;
    public bool switched = false;

    GameObject theDoor;
    Door doorScript;


    // Use this for initialization
    void Start () {
        theDoor = GameObject.Find("ObjectDoor");
         doorScript = theDoor.GetComponent<Door>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            switching = true;
        }

        if(Input.GetKeyUp(KeyCode.T))
        {
            switching = false;
        }
        DoItWorks();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isAbleSwitch = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isAbleSwitch = false;
        }
    }

    private void DoItWorks()
    {
        if (isAbleSwitch) {
            if (switching)
            {
                if (switched == false)
                {
                    
                    switched = true;
                    switching = false;
                    doorScript.doorOpen = false;
                }
                else
                {
                    switched = false;
                    switching = false;
                    doorScript.doorOpen = true;
                }
            }

        }
    }
}
