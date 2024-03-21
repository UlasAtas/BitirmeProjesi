using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelPaneli : MonoBehaviour
{
    public GameObject[] paneller;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("level1"))
        {
            paneller[1].SetActive(true);
        }

        if (collision.gameObject.CompareTag("level2"))
        {
            paneller[0].SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("level1"))
        {
            paneller[1].SetActive(false);
        }
        
        if (collision.gameObject.CompareTag("level2"))
        {
            paneller[0].SetActive(false);
        }

    }
    //public void PanelAcici() 
    //{
    //    paneller[0].SetActive(true);
    //}
}
