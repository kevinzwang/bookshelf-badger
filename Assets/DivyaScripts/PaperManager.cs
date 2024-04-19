using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperControl : MonoBehaviour
{

    public GameObject goodPaper;
    public GameObject jammed;
    public bool paperSet;

    // Start is called before the first frame update
    void Start()
    {
        paperSet = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "paperTray" && !jammed.activeSelf){
            goodPaper.SetActive(true);
            gameObject.SetActive(false);
            paperSet = true;
        }

    }
}