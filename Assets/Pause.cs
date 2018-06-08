using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject PauseMenu;
    public GameObject SoundMenu;
    public GameObject Controllers;
    public GameObject PauseCanvas;

    public Slider sliderVolume;
    AudioSource audioSource;
    public Toggle muteToggle;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        ContinueGame();
    }

    private void Update()
    {
        audioSource.volume = sliderVolume.value;
        audioSource.mute = muteToggle.isOn;
    }

    public void PauseGame ()
    {
        PauseCanvas.SetActive(true);
        Controllers.SetActive(false);
        SoundMenu.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ContinueGame()
    {
        PauseCanvas.SetActive(false);
        Controllers.SetActive(true);
        SoundMenu.SetActive(false);
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SoundSettings()
    {
        PauseCanvas.SetActive(true);
        Controllers.SetActive(false);
        SoundMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }



}
