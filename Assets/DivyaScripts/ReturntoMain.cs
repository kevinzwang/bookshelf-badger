using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoMain : MonoBehaviour
{
    GameManager gameManager;

    void Awake() 
    {
        gameManager = GameManager.Instance;
    }

    public void Return() 
    {
        if (PrinterManager.win) {
            gameManager.AddScore(1);
        }

        gameManager.ExitMiniGame();
    }
}
