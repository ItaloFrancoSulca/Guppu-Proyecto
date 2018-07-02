using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour {

    public float speed;

    static public bool enemyFloor = false;
    static public bool enemyWall = false;

    
    // Update is called once per frame
    void Update () {
        
        transform.Translate(Vector3.forward*(speed) * Time.deltaTime);

        if (enemyFloor == true)
        {
            transform.rotation *= Quaternion.Euler(0, 180, 0);
        }

        if (enemyWall == true)
        {
            transform.rotation *= Quaternion.Euler(0, 180, 0);
        }
    }
    


}
