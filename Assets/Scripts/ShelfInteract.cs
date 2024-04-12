using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfInteract : MonoBehaviour
{
    Interactive interactive;
    GameManager gameManager;
    public string letter;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        interactive = gameObject.GetComponent<Interactive>();
    }

    void OnMouseDown() {
        if (!interactive.interactEnabled || gameManager.currentBook == null) return;

        if (gameManager.currentBook.authorLetter == letter) {
            gameManager.EnterMiniGame("MinigameShelving");
        }
    }
}
