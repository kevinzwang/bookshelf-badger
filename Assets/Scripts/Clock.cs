using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public float totalTimeSecs = 300f;

    private float timeElapsed = 0f;
    private GameManager gameManager;
    private Image clockImage;

    void Awake()
    {
        clockImage = GetComponent<Image>();
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        clockImage.fillAmount = timeElapsed / totalTimeSecs;
        
        if (timeElapsed >= totalTimeSecs)
        {
            gameManager.EndGame();
        }
    }
}
