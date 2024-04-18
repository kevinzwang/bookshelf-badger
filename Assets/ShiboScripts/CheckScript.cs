using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckScript : MonoBehaviour
{
    public Toggle tog1;
    public Toggle tog2;
    public Toggle tog3;
    public Toggle tog4;

    public Toggle tog5;
    public GameObject infoScreen;
    public GameObject inputScreen;
    public GameObject dialoguePrefab;

    private bool inputScreenInstantiated = false;
    private bool dialogueInstatiated = false;

    void Update()
    {
        if (tog1.isOn && tog2.isOn && tog3.isOn && tog4.isOn && tog5.isOn && !inputScreenInstantiated && !dialogueInstatiated)
        {
            infoScreen.SetActive(false);
            // Instantiate(inputScreen);
            inputScreen.SetActive(true);
            inputScreenInstantiated = true;

            //dialoguePrefab.SetActive(true);
            dialogueInstatiated = true;
        
        }
    }
}
