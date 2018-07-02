using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCCollider : MonoBehaviour
{
    static public bool ableToHack;
    public GameObject buttomToHack;

    // Use this for initialization
    void Start()
    {
        buttomToHack.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ableToHack = true;
            buttomToHack.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ableToHack = false;
            buttomToHack.SetActive(false);
        }
    }

    public void Hack()
    {
        SceneManager.LoadScene(2);
    }


}
