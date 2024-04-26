using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardElephant : MonoBehaviour
{
    private static CardElephant instance;
    
    GameManager gameManager;
    SpriteRenderer spriteRenderer;

    public GameObject regularNPC;

    void Awake()
    {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
            return;
        }

        gameManager = GameManager.Instance;
        spriteRenderer = GetComponentInParent<SpriteRenderer>();

        DontDestroyOnLoad(gameObject);
        gameObject.SetActive(false);
    }

    void OnEnable() {
        regularNPC.SetActive(false);
    }

    void OnMouseEnter() {
        spriteRenderer.color = Color.green;
    }

    void OnMouseExit() {
        spriteRenderer.color = Color.white;
    }

    void OnMouseDown() {
        gameObject.SetActive(false);
        regularNPC.SetActive(true);

        gameManager.SetPatron("elephant");
        gameManager.EnterMiniGame("MinigameCard");
    }

}
