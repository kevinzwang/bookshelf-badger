using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivyaClick : MonoBehaviour
{

    public GameObject checkButton;
    public GameObject Xbutton;
    public GameObject lidClosed;
    public GameObject lidOpen;
    public GameObject quest;
    public static int passwordProgress;
    public static bool win3;


    private void Awake()
    {
        passwordProgress = 1;
        win3 = false;

    }

    void OnMouseDown() {
        Debug.Log(gameObject.name);
        if (gameObject.name == "lid_closed" || gameObject.name == "lid_open"){
            lidClosed.SetActive(!lidClosed.activeSelf);
            lidOpen.SetActive(!lidOpen.activeSelf);
            quest.SetActive(false);
        }


        if (gameObject.name == "buttonYellow" && passwordProgress == 1){
            passwordProgress = 2;
        } else if (gameObject.name == "buttonPurple" && (passwordProgress == 2 || passwordProgress == 3 || passwordProgress == 4)) {
            if (passwordProgress == 2){
                passwordProgress = 3;
            } else if (passwordProgress == 3){
                passwordProgress = 4;
            } else {
                passwordProgress = 5;
            }
        } else if (gameObject.name == "buttonGreen" && passwordProgress == 5) {
            passwordProgress = 6;
            
        } else if (gameObject.name == "buttonBlue" && (passwordProgress == 6 || passwordProgress == 7)) {
            if (passwordProgress == 6){
                passwordProgress = 7;
            } else {
                checkButton.SetActive(true);
                Xbutton.SetActive(false);
                win3 = true;
            }
        } else {
            passwordProgress = 1;
        }
    }
}
