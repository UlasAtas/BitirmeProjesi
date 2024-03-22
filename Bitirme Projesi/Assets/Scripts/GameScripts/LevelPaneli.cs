using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LevelPaneli : MonoBehaviour
{
    public GameObject[] paneller;
    //public TextMeshProUGUI[] bestScoreTexts;
    //public int highScore;
    //public TextMeshProUGUI highScoreText;

    //private void Start()
    //{
    //    highScore = PlayerPrefs.GetInt("HighScore", 0);
    //    highScoreText.text = /*"En Yüksek Skor: " +*/ highScore.ToString();
    //}

    //public void SaveHighScore(int newHighScore)
    //{
    //    highScore = newHighScore;
    //    PlayerPrefs.SetInt("HighScore", highScore);
    //    highScoreText.text = /*"En Yüksek Skor: " +*/ highScore.ToString();
    //}



    //void UpdateScore(int scoreToAdd)
    //{
    //    currentScore = PlayerPrefs.GetInt("HighScore", 0);
    //    currentScore += scoreToAdd;

    //    // Yeni skor eski en yüksek skordan büyükse, en yüksek skoru güncelle
    //    if (currentScore > PlayerPrefs.GetInt("HighScore", 0))
    //    {
    //        PlayerPrefs.SetInt("HighScore", currentScore);
    //        PlayerPrefs.Save();
    //    }
    //}

    //void DisplayScore()
    //{        

    //    bestScoreTexts[0].text = currentScore.ToString();
    //}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("level1"))
        {
            paneller[0].SetActive(true);
        }

        if (collision.gameObject.CompareTag("level2"))
        {
            paneller[1].SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("level1"))
        {
            paneller[0].SetActive(false);
        }
        
        if (collision.gameObject.CompareTag("level2"))
        {
            paneller[1].SetActive(false);
        }

    }
    //public void PanelAcici() 
    //{
    //    paneller[0].SetActive(true);
    //}
}
