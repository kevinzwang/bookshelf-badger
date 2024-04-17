using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkController : MonoBehaviour
{
    public GameObject magCheck;
    public GameObject yellowCheck;
    public GameObject cyanCheck;
    public GameObject keyCheck;

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
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "cartridgeSlot-magenta" && gameObject.name == "cartridge-magenta"){
            Debug.Log("hi");
            magCheck.SetActive(true);
            GameObject.Find("redX_magenta").SetActive(false);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.name == "cartridgeSlot-yellow" && gameObject.name == "cartridge-yellow"){
            yellowCheck.SetActive(true);
            GameObject.Find("redX_yellow").SetActive(false);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.name == "cartridgeSlot-cyan" && gameObject.name == "cartridge-cyan"){
            Debug.Log("hi");
            cyanCheck.SetActive(true);
            GameObject.Find("redX_cyan").SetActive(false);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.name == "cartridgeSlot-key" && gameObject.name == "cartridge-key"){
            keyCheck.SetActive(true);
            GameObject.Find("redX_key").SetActive(false);
            gameObject.SetActive(false);
        }

        

    }
}
