using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collisions : MonoBehaviour {
    
    public GameObject soundEffectController;
    SoundEffect_Vista soundEffect_Vista;
	// Use this for initialization
	void Start () {
		soundEffect_Vista = soundEffectController.GetComponent<SoundEffect_Vista>();
	}
	

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

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
