using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;

public class DivyaDragandDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerClickHandler
{
    private Canvas canvas;
    private Vector3 mousePosition;
    private Vector3 offset;
    private RectTransform rectTransform;
    // private bool isEnlarged = false;
    // private Vector3 originalScale;

    private void Awake() 
    {
    //     //originalScale = transform.localScale;
        rectTransform = GetComponent<RectTransform>();
         
    //     //canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        
        if (eventData.pointerDrag == gameObject)
        {
            //mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            //transform.position = Vector3.Lerp(transform.position, mousePosition, followSpeed);
            //offset = transform.position - mousePosition;
            transform.position = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
            // Calculate the movement delta based on the drag
            // Apply the movement to the GameObject's position
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
    //     Debug.Log("OnEndDrag");
    //     //canvasGroup.alpha = 1f;
    //     //canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mousePosition.z = 0;
        offset = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector3)rectTransform.position;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //isEnlarged = !isEnlarged;
        //if (isEnlarged)
       //{
        //    transform.localScale = originalScale * 3f;
        //}
        //else
        //{
        //    transform.localScale = originalScale;
        //}
    }
}
