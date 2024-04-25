using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public float totalTimeSecs = 300f;

    private float timeElapsed = 0f;
    private GameManager gameManager;
    private TMP_Text clockText;

    void Awake()
    {
        clockText = GetComponent<TextMeshProUGUI>();
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= totalTimeSecs)
        {
            gameManager.EndGame();
        }
        
        int secondsLeft = (int)(totalTimeSecs - Math.Ceiling(timeElapsed));
        
        int min = secondsLeft / 60;
        int sec = secondsLeft % 60;

        clockText.text = min.ToString("00") + ":" + sec.ToString("00");
    }
}
