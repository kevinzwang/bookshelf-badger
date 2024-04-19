using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragandDrop : MonoBehaviour
{
    public GameObject selectedObject;
    private Vector3 offset;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

            if (targetObject)
            {
                selectedObject = targetObject.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }

        if (selectedObject && selectedObject.CompareTag("movable"))
        {
            selectedObject.transform.position = mousePosition + offset;
        }

        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (selectedObject)
        {
            // Get the sorting order of the collided object's sprite renderer
            int sortingOrder = collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder;

            // Increase the sorting order by 1 to move the selected object above the collided object
            selectedObject.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder + 1;
        }
    }
}
