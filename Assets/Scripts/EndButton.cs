using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    public void RestartGame() {
        Debug.Log("Restarting game");
        gameManager.RestartGame();
    }
}
