using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject soundMenu;

    public Slider sliderVolume;
    public AudioSource audioSource;
    public Toggle muteToggle;
    void Start () {
        ReturnToMenu();
	}

    private void Update()
    {
        audioSource.volume = sliderVolume.value;
        audioSource.mute = muteToggle.isOn;
    }

    public void StartGame ()
    {
        SceneManager.LoadScene(1);
    }
	
    public void SoundSettings()
    {
        soundMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void ReturnToMenu()
    {
        mainMenu.SetActive(true);
        soundMenu.SetActive(false);
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
