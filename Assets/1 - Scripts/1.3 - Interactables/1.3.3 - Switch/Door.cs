using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool doorOpen = false;
    BoxCollider _boxCollider;
    MeshRenderer _meshRenderer;

	// Use this for initialization
	void Start () {
        _boxCollider = GetComponent<BoxCollider>();
        _meshRenderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        if (doorOpen)
        {
            _boxCollider.enabled = true;
            _meshRenderer.enabled = true;
        }
        else
        {
            _boxCollider.enabled = false;
            _meshRenderer.enabled = false;
        }
		
	}
    
}
