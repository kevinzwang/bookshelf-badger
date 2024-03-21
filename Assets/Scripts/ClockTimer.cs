using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClockTimer : MonoBehaviour
{
    GameManager gameManager;
    public float totalTime = 60;
    public TMP_Text clockText;

    float startTime;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        float timeElapsed = Time.time - startTime;
        float timeRemaining = totalTime - timeElapsed;

        if (timeRemaining <= 0)
        {
            gameManager.EndGame();
        }

        clockText.text = timeRemaining.ToString("F0");
    }
}
