using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartManager : MonoBehaviour
{
    public GameObject magCheck;
    public GameObject yellowCheck;
    public GameObject cyanCheck;
    public GameObject keyCheck;
    public static bool win2;

    // Start is called before the first frame update
    void Start()
    {
        win2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (magCheck.activeSelf && yellowCheck.activeSelf && cyanCheck.activeSelf && keyCheck.activeSelf){
            win2 = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "cartridgeSlot-magenta" && gameObject.name == "cartridge-magenta"){
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
