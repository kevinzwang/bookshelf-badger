using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour
{
    

    public GameObject animatedPrinter;
    public GameObject cyanX;
    public GameObject magentaX;
    public GameObject keyX;
    public GameObject yellowX;
    public GameObject paperX;
    public GameObject passwordX;
    public GameObject paperInsert;
    private Animator animator;
    private PaperManager script1;
    private CartManager script2;
    private DivyaClick script3;
    public GameObject printerbody;


    void Start()
    { 
        // script1 = FindObjectOfType<PaperManager>();
        // script2 = FindObjectOfType<CartManager>();
        // script3 = FindObjectOfType<DivyaClick>();
        // animator = animatedPrinter.GetComponent<Animator>();
        // Debug.Log(script1.win1);
        // Debug.Log(script2.win2);
        // Debug.Log(script3.win3);



    }

    void Update()
    {
        if (DivyaClick.win3 && CartManager.win2 && PaperManager.win1) {
            Debug.Log("Win");
            printerbody.SetActive(false);
            animatedPrinter.SetActive(true);
        }
    }

    
}