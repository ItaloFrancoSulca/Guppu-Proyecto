using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxRespawn : MonoBehaviour
{

    public GameObject boxSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Nether")
        {
            transform.position = boxSpawn.transform.position;
        }
    }


}