using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfInteract : MonoBehaviour
{
    GameManager gameManager;
    public string letter;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    void OnMouseDown() {
        if (gameManager.currentBook != null && gameManager.currentBook.authorLetter == letter) {
            gameManager.EnterMiniGame("MinigameShelving");
        }
    }
}
