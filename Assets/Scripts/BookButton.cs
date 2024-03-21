using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookButton : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        Debug.Log(gameManager);
    }

    public void CloseBook() {
        Debug.Log("Close book");
        gameManager.CloseBook();
    }
}
