using UnityEngine;

public class MinigameInteract : MonoBehaviour
{
    public string minigame;
    Interactive interactive;

    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        interactive = gameObject.GetComponent<Interactive>();
    }

    void OnMouseDown() {
        if (!interactive.interactEnabled) return;

        gameManager.EnterMiniGame(minigame);
    }
}
