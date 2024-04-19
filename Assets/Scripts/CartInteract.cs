using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartInteract : MonoBehaviour
{
    GameManager gameManager;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        spriteRenderer = GetComponentInParent<SpriteRenderer>();
    }

    void OnMouseEnter() {
        if (gameManager.currentBook == null) {
            spriteRenderer.color = Color.green;
        } else {
            spriteRenderer.color = Color.red;
        }
    }

    void OnMouseExit() {
        spriteRenderer.color = Color.white;
    }

    void OnMouseDown() {
        if (gameManager.currentBook == null) {
            gameManager.GetNewBook();
        }
    }
}
