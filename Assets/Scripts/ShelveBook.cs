using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelveBook : MonoBehaviour
{
    GameManager gameManager;
    public BookToShelve book;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    void OnMouseDown() {
        book.Shelve();
    }
}
