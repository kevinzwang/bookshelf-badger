using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour
{
    

    public GameObject animatedPrinter;
    public GameObject printerDialogue;
    private Animator animator;
    private PaperManager script1;
    private CartManager script2;
    private DivyaClick script3;
    public GameObject printerbody;
    public static bool win;


    void Start()
    { 
        win = false;
        


    }

    void Update()
    {
        if (DivyaClick.win3 && CartManager.win2 && PaperManager.win1) {
            printerbody.SetActive(false);
            animatedPrinter.SetActive(true);
            win = true;
        }
    }

    
}