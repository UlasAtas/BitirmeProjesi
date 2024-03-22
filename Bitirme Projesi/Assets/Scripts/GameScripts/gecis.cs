using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gecis : MonoBehaviour
{
    // Start is called before the first frame update
    public void OyunSahnesineGec1()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void OyunSahnesineGec2()
    {
        SceneManager.LoadScene("Level_2");
    }

}
