using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckScript : MonoBehaviour
{
    public Toggle[] togs;
    public GameObject infoScreen;
    public GameObject inputScreen;
    public GameObject dialoguePrefab;

    private bool inputScreenInstantiated = false;
    private bool dialogueInstatiated = false;

    void Update()
    {
        if (togs[0].isOn && togs[1].isOn && togs[2].isOn && togs[3].isOn && togs[4].isOn && !inputScreenInstantiated && !dialogueInstatiated)
        {
            infoScreen.SetActive(false);
            inputScreen.SetActive(true);
            inputScreenInstantiated = true;
            dialogueInstatiated = true;
        
        }
    }
}
