using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameInteract : MonoBehaviour
{
    GameManager gameManager;
    SpriteRenderer spriteRenderer;
    public string sceneName;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    

    void OnMouseEnter() {
        spriteRenderer.color = Color.green;
    }

    void OnMouseExit() {
        spriteRenderer.color = Color.white;
    }

    void OnMouseDown() {
        gameManager.EnterMiniGame(sceneName);
    }
}
