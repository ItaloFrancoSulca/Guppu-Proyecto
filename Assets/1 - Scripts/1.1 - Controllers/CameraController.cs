using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    int rotationDegree = 0;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C))
        {
            rotationDegree= rotationDegree +90;
        }
        if (rotationDegree >= 360)
        {
            rotationDegree = 0;
        }

        transform.rotation = Quaternion.Euler(0, rotationDegree, 0);
	}
}
