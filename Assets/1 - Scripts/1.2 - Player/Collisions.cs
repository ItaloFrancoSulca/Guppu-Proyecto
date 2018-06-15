using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour {

    public bool dead;
    public GameObject soundEffectController;
    SoundEffect_Vista soundEffect_Vista;
	// Use this for initialization
	void Start () {
		soundEffect_Vista = soundEffectController.GetComponent<SoundEffect_Vista>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            dead = true;
            
            int playLoseSound = Random.Range(1,3);

            switch(playLoseSound){
                case 1:
                soundEffect_Vista.RocotonSFX();
                break;

                case 2:
                soundEffect_Vista.LoseSFX();
                break;

            }
            
        }

        
    }

    private void OnTriggerEnter (Collider obj){

        if (obj.gameObject.tag == "Nether"){
            soundEffect_Vista.FallSFX();
        }

        if (obj.gameObject.tag == "Rune"){
            soundEffect_Vista.InteresanteSFX();
        }
    }
}
