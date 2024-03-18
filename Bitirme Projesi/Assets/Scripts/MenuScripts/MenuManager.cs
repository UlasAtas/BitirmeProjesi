using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    
    public GameObject[] panels;
    public Slider volumeSlider;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource.volume = volumeSlider.value;
    }

    public void StartOnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OptionsOnClick()
    {
        panels[0].SetActive(false);
        panels[1].SetActive(true);
    }

    public void CikisOnClick()
    {
        Application.Quit();
    }

    public void MenuOnClick()
    {
        panels[1].SetActive(false);
        panels[0].SetActive(true);
    }


    public void VolumeSlider()
    {
        audioSource.volume = volumeSlider.value;
    }
}
