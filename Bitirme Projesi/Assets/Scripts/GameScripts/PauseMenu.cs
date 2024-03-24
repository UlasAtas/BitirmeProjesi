using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    bool isPaused;
    public GameObject[] panels;
    //public Slider volumeSlider;
    //public AudioSource audioSource;
    //public float musicVolume;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;

        //if (!PlayerPrefs.HasKey("MusicVolume"))
        //{
        //    musicVolume = volumeSlider.value;
        //}
        //else
        //{
        //    musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        //}

        //audioSource.volume = musicVolume;
        //volumeSlider.value = musicVolume;
    }

    private void Update()
    {
        Pause();
    }


    //public void OnVolumeChange()
    //{
    //    musicVolume = volumeSlider.value;
    //    PlayerPrefs.SetFloat("MusicVolume", musicVolume);
    //    audioSource.volume = musicVolume;
    //}

    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Time.timeScale = 0f;
                panels[0].SetActive(true);
                isPaused = true;
                
            }
            else
            {
                Time.timeScale = 1f;
                panels[0].SetActive(false);
                isPaused = false;
                
            }
        }
    }


    public void OnOptionsClick()
    {
        panels[0].SetActive(false);
        panels[1].SetActive(true);
    }


    public void OnMenuClick()
    {
        panels[1].SetActive(false);
        panels[0].SetActive(true);
    }

    public void OnContinueClick()
    {
        Time.timeScale = 1f;
        panels[0].SetActive(false);
        isPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
