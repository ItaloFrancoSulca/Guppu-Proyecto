using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect_Vista : MonoBehaviour {
    AudioSource audioSource;
    SoundEffect_Modelo soundEffect_Modelo;
    // Use this for initialization

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        soundEffect_Modelo = GetComponent<SoundEffect_Modelo>();
    }

    void Start()
    {
        audioSource.PlayOneShot(soundEffect_Modelo.sfxNarrador, soundEffect_Modelo.volume);
    }

    // Update is called once per frame
    public void RocotonSFX()
    {
        audioSource.PlayOneShot(soundEffect_Modelo.sfxRocoton, soundEffect_Modelo.volume);
    }
    public void WinSFX()
    {
        audioSource.PlayOneShot(soundEffect_Modelo.sfxWin, soundEffect_Modelo.volume);
    }
    public void FallSFX()
    {
        audioSource.PlayOneShot(soundEffect_Modelo.sfxFall, soundEffect_Modelo.volume);
    }
    public void LoseSFX()
    {
        audioSource.PlayOneShot(soundEffect_Modelo.sfxLose, soundEffect_Modelo.volume);
    }
    public void InteresanteSFX()
    {
        audioSource.PlayOneShot(soundEffect_Modelo.sfxInteresante, soundEffect_Modelo.volume);
    }
}
