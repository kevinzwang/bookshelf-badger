using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click : MonoBehaviour
{

    public GameObject selectedObject;
    public GameObject lid_open;
    public GameObject lid_closed;
    Vector3 offset;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;

            }

        }

        //if (selectedObject)
        //{
        //    selectedObject.transform.position = mousePosition + offset;
        //}

        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            if (selectedObject.name == "jammedPaperAirplane"){
                selectedObject.SetActive(false);
            }

            //if jammedPaperAirplane doesn't exist then you can open lid

            if (selectedObject.name == "lid_open"){
                selectedObject.SetActive(false);
                lid_closed.SetActive(true);
            }

            if (selectedObject.name == "lid_closed"){
                selectedObject.SetActive(false);
                lid_open.SetActive(true);
            }

        }
    }

    
}