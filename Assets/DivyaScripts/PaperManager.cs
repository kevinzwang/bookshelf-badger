using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperManager : MonoBehaviour
{

    public GameObject goodPaper;
    public GameObject paperCheck;
    public GameObject paperX;
    public static bool win1;

    // Start is called before the first frame update
    void Start()
    {
        win1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "paperTray"){
            goodPaper.SetActive(true);
            gameObject.SetActive(false);
            paperX.SetActive(false);
            paperCheck.SetActive(true);
            win1 = true;
        }

    }
}