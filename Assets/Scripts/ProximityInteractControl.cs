using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityInteractControl : MonoBehaviour
{
    Interactive interactive;

    private void Awake()
    {
        interactive = gameObject.GetComponentInParent<Interactive>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactive.interactEnabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactive.interactEnabled = false;
        }
    }
}
