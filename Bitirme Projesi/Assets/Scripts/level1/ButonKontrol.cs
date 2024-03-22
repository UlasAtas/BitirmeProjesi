using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonKontrol : MonoBehaviour
{
    public GameObject panel;
    public void Menu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void TekrarBasla()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //Time.timeScale = 1.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(!panel.activeSelf);
            if (panel.activeSelf)
            {
                Time.timeScale = 0f;

            }
            else
            {
                Time.timeScale = 1f;

            }
        }
    }

}
