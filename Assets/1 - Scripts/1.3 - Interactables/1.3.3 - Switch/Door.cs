using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    

    public Transform openTransform;
    public Transform closeTransform;
    public GameObject particlesDoor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (PressurePlateCollider.isPressed)
        {
            transform.position = Vector3.MoveTowards(transform.position, closeTransform.position, 8*Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, openTransform.position, 8 * Time.deltaTime);
        }

		if (transform.position.y != openTransform.position.y && transform.position.y != closeTransform.position.y) {
            particlesDoor.SetActive(true);
        }
        else
        {
            particlesDoor.SetActive(false);
        }
	}
    
}
