using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMap : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    public void ExitMiniGame() {
        gameManager.ExitMiniGame();
    }
}
