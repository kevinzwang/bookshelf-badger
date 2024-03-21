using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChange : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        Debug.Log(gameManager);
    }

    public void StartGame() {
        SceneManager.LoadScene("MapScene");
    }

    public void GoBackToMain() {
        SceneManager.LoadScene("MainMenuScene");
    }
}
