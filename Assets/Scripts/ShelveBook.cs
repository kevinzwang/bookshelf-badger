using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelveBook : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    void OnMouseDown() {
        gameManager.ExitMiniGame();
    }
}
