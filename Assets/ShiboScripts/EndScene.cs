using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    GameManager gameManager;

    void Awake() 
    {
        gameManager = GameManager.Instance;
    }

    public void Return() 
    {
        gameManager.AddScore(1);
        gameManager.ExitMiniGame();
    }
}
