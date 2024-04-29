using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHintScript : MonoBehaviour
{
    public GameObject hintDialogue;

    public void hint() 
    {
        Instantiate(hintDialogue);
    }

}
