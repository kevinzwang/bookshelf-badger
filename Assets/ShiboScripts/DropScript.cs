using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropScript : MonoBehaviour, IDropHandler
{
    public string slotIdentifier;
    public GameObject dialoguePrefab;
    public Transform canvasTransform;
    GameManager gameManager;

    void Awake() {
        gameManager = GameManager.Instance;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        if (eventData.pointerDrag != null) 
        {
            if (slotIdentifier == "RejectBin")
            {
                Debug.Log("Get out now!");
                GameObject dialogue = Instantiate(dialoguePrefab, canvasTransform);
                
                Canvas canvas = dialogue.GetComponent<Canvas>();
                if (canvas != null)
                {
                    canvas.sortingOrder = 999;
                }
            }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            StartCoroutine(EndScene());
        }
    }

    IEnumerator EndScene() {
        yield return new WaitForSeconds(3f);
        gameManager.ExitMiniGame();
        gameManager.AddScore(1);
    }
}


