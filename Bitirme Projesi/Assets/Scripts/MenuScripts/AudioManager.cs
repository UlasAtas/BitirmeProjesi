using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    
    public AudioSource audioSource;
    public float musicVolume;
    public Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            musicVolume = volumeSlider.value;
        }
        else
        {
            musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        }

        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    public void OnVolumeChange()
    {
        musicVolume = volumeSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        audioSource.volume = musicVolume;
    }


    
}
