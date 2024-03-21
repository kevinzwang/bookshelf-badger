using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartInteract : MonoBehaviour
{
    Interactive interactive;
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        interactive = gameObject.GetComponent<Interactive>();
    }


    void OnMouseDown() {
        if (!interactive.interactEnabled) return;

        gameManager.GetNewBook();
    }
}
