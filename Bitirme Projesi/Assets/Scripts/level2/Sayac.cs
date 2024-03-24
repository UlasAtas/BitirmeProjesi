using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sayac : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI timerText;
    private float timeRemaining = 100f;
    private bool timerIsRunning = true;
    public GameObject panel;
    PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        Invoke("TextDestroy", 3);
    }

    void TextDestroy()
    {
        Destroy(text);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                panel.SetActive(true);
                playerMovement.moveSpeed = 0;
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        
        float seconds = Mathf.FloorToInt(timeToDisplay);

        timerText.text = seconds.ToString();
    }
}
