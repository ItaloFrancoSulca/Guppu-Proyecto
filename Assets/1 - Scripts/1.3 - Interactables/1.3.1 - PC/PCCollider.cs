using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCCollider : MonoBehaviour
{
    static public bool ableToHack;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ableToHack = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ableToHack = false;
        }
    }



}
