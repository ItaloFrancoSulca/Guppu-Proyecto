using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdView : MonoBehaviour {

    ThirdModel thirdModelScript;

    private void Awake()
    {
        thirdModelScript = GetComponent<ThirdModel>();
    }

    public void InstantiateFirst () {
		Instantiate(thirdModelScript.columnGo[0], new Vector3(6, thirdModelScript.randomPosition, 0), Quaternion.Euler(0, 0, 0));
	}

    public void InstantiateSecond() {
        Instantiate(thirdModelScript.columnGo[1], new Vector3(6, thirdModelScript.randomPosition, 0), Quaternion.Euler(0, 0, 0));
    }

    public void InstantiateThird()
    {
        Instantiate(thirdModelScript.columnGo[2], new Vector3(6, thirdModelScript.randomPosition, 0), Quaternion.Euler(0, 0, 0));
    }
}
