using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScoreSave : MonoBehaviour
{
    public TextMeshProUGUI[] highScoreText;

    private void Start()
    {
        ScoreDisplay();
    }

    void ScoreDisplay()
    {
        highScoreText[0].text = PlayerPrefs.GetInt("highScore").ToString();
        highScoreText[1].text = PlayerPrefs.GetInt("highScore2").ToString();
    }
}
