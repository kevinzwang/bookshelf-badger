using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click : MonoBehaviour
{

    // public GameObject selectedObject;
    // public GameObject lid_open;
    // public GameObject lid_closed;
    // public GameObject jammed;
    // public GameObject redBunny;
    // public GameObject greenBunny;
    // public GameObject goodPaper;
    // public int passwordProgress;

    // Vector3 offset;

    // void Update()
    // {
    //     Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

    //         if (targetObject)
    //         {
    //             selectedObject = targetObject.transform.gameObject;
    //             offset = selectedObject.transform.position - mousePosition;

    //         }

    //     }

    //     if (Input.GetMouseButtonUp(0) && selectedObject)
    //     {
    //         if (selectedObject.name == "jammedPaperAirplane"){
    //             selectedObject.SetActive(false);
    //         }

    //         if (selectedObject.name == "lid_open"){
    //             selectedObject.SetActive(false);
    //             //if (paperSet) {
    //                 goodPaper.SetActive(false);
    //             //}
    //             lid_closed.SetActive(true);
    //         }

    //         if (selectedObject.name == "lid_closed" && !jammed.activeSelf){
    //             selectedObject.SetActive(false);
    //             if (paperSet) {
    //                 goodPaper.SetActive(true);
    //             }
    //             lid_open.SetActive(true);
    //         }


    //         // button presses

    //         if (selectedObject.name == "buttonBlue" && passwordProgress == 1){
    //             passwordProgress = 2;

    //         } else if (selectedObject.name == "buttonGreen" && passwordProgress == 2) {
    //             passwordProgress = 3;

    //         } else if (selectedObject.name == "buttonPurple" && passwordProgress == 3) {
    //             passwordProgress = 4;
            
    //         } else if (selectedObject.name == "buttonYellow" && passwordProgress == 4) {
    //             greenBunny.SetActive(true);
    //             redBunny.SetActive(false);

    //         } else {
    //             passwordProgress = 1;
                
    //         }

    //     }

        
    // }
    

    
}