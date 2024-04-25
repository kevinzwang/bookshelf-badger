using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragandDrop : MonoBehaviour
{
    public GameObject selectedObject;
    private Vector3 offset;
    private int sortingOrderCollision;

    void Update()
    {
        //Debug.Log("inside update");
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log("after mouse position");
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("mouse clicked");
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

            if (targetObject)
            {
                //Debug.Log("target exists");
                selectedObject = targetObject.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }

        if (selectedObject && selectedObject.tag == "movable")
        {
            //Debug.Log("selected exists");
            selectedObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            selectedObject.transform.position = mousePosition + offset;
            //Debug.Log(selectedObject.transform.position);
            //Debug.Log(selectedObject.name);
        }
        

        if (Input.GetMouseButtonUp(0))
        {
            selectedObject.GetComponent<SpriteRenderer>().color = Color.white;
            selectedObject = null;
        }
    }

}
