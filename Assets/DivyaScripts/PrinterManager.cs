using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer screenSprite;
    public GameObject goodPaper;
    public GameObject cyanEmpty;
    public GameObject magEmpty;
    public GameObject yellEmpty;
    public GameObject blackEmpty;


    void Start()
    {
        screenSprite =  GameObject.Find("screen").GetComponent<SpriteRenderer>();
        screenSprite.color = Color.red;

        goodPaper.SetActive(false);


    
    }

    void Update()
    {

        if (goodPaper.activeSelf && !cyanEmpty.activeSelf && !magEmpty.activeSelf && !yellEmpty.activeSelf && !blackEmpty.activeSelf) {
            screenSprite.color = Color.blue;
        }
    }

    
}
