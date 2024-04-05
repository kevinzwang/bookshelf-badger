using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkController : MonoBehaviour
{
    //public GameObject fullCart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "fullMagenta" && gameObject.name == "newMagenta"){
            GameObject.Find("emptyMagenta").SetActive(false);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.name == "fullYellow" && gameObject.name == "newYellow"){
            GameObject.Find("emptyYellow").SetActive(false);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.name == "fullCyan" && gameObject.name == "newCyan"){
            GameObject.Find("emptyCyan").SetActive(false);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.name == "fullBlack" && gameObject.name == "newBlack"){
            GameObject.Find("emptyBlack").SetActive(false);
            gameObject.SetActive(false);
        }

    }
}
