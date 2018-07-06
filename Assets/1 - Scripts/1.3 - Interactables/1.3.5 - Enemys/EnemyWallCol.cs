using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWallCol : MonoBehaviour {



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag =="Box")
        {
            EnemyController.enemyWall = true;
        }

        if (other.gameObject.tag == "Floor")
        {
            EnemyController.enemyFloor = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag =="Box")
        {
            EnemyController.enemyWall = false;
        }

        if (other.gameObject.tag == "Floor")
        {
            EnemyController.enemyFloor = true;
        }
    }
}
