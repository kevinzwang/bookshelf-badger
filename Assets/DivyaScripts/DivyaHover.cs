using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivyaHover : MonoBehaviour
{

    private void Awake()
    {


    }
    

    void OnMouseEnter() {
        Debug.Log("enter");
        if (gameObject.tag == "key") {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        } else {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        // if its a main item turn green
        //else turn red
    }

    void OnMouseExit() {
        Debug.Log("hi");
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        // turn back to white
    }

}
