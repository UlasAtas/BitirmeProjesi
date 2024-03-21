using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonKontrol : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
    public void TekrarBasla()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //Time.timeScale = 1.0f;
    }


}
