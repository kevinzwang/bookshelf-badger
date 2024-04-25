using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropScript : MonoBehaviour, IDropHandler
{
    public string slotIdentifier;
    public GameObject dialoguePrefab;
    public Transform canvasTransform;
    public GameObject returnButton;
    public GameObject anim;
    public GameObject thisItem;
    GameManager gameManager;
    public GameObject reject;

    GameObject id;
    GameObject oldDialogue;

    void Awake() 
    {
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
                dialoguePrefab.SetActive(true);
                returnButton.SetActive(true);
                id = GameObject.FindGameObjectWithTag("ID");
                id.SetActive(false);
                anim.SetActive(true);
                thisItem.SetActive(false);
                reject.SetActive(true);
                oldDialogue = GameObject.FindGameObjectWithTag("dialogue");
                oldDialogue.SetActive(false);
            }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}


