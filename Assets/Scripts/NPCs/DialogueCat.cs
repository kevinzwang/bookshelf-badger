using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueCat : MonoBehaviour
{
    private static DialogueCat instance;
    
    GameManager gameManager;
    SpriteRenderer spriteRenderer;

    public GameObject regularNPC;
    public GameObject dialogue;

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
        dialogue.SetActive(true);
    }

    public void EndDialogue() {
        InMemoryVariableStorage variableStorage = dialogue.GetComponent<InMemoryVariableStorage>();

        bool success;
        variableStorage.TryGetValue("$catSuccess", out success);

        if (success) {
            gameManager.AddScore(2);
        }

        gameObject.SetActive(false);
        regularNPC.SetActive(true);
    }
}
