using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInHand : MonoBehaviour
{

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    void OnMouseDown() {
        gameManager.OpenBook();
    }
}
