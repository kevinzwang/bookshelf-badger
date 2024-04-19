using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfInteract : MonoBehaviour
{
    GameManager gameManager;
    SpriteRenderer spriteRenderer;
    public string letter;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        spriteRenderer = GetComponentInParent<SpriteRenderer>();
    }
    

    void OnMouseEnter() {
        if (gameManager.currentBook != null && gameManager.currentBook.authorLetter == letter) {
            spriteRenderer.color = Color.green;
        } else {
            spriteRenderer.color = Color.red;
        }
    }

    void OnMouseExit() {
        spriteRenderer.color = Color.white;
    }

    void OnMouseDown() {
        if (gameManager.currentBook != null && gameManager.currentBook.authorLetter == letter) {
            gameManager.EnterMiniGame("MinigameShelving");
        }
    }
}
