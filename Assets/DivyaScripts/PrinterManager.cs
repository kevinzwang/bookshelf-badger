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


// cannot move beyond certain area or gets returned to og spot
// cannot be on top of printer
// cannot move anything except moveable items
// how to add animation
// glowing green button to play animation
// red and green bunny to indicate correct reset password
// glowing paper
// why is animation printer blurry
// fix background password
// how to do animation
// randomize problems
// randomize cartidge locations and maybe other items as well?
// button size?
// code password
// move dragged object by changing sortimg order - if collision object => sorting order, set the sorting order to collision object sortung order + 1
