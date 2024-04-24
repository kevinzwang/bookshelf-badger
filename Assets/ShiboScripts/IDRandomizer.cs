using System.Collections;
using System.Collections.Generic;
using Ink.Parsed;
using UnityEngine;

public class IDRandomizer : MonoBehaviour 
{
    public GameObject[] IDSToEnable;
    public GameObject[] FakeIDSToEnable;
    public GameObject[] ScreensToEnable;
    public GameObject[] DialoguesToEnableNPC1;
    public GameObject[] DialoguesToEnableNPC2;
    public GameObject[] DialoguesToEnableNPC3;

    public GameObject hintDialogue;

    public GameObject introDialogue;

    int ind;
    int appind;
    int percentage;
    int npc;

     void Start()
    {
        npc = Random.Range(0, 3);
        percentage = Random.Range(0, 100);
        Debug.Log("Percent: " + percentage);
        GameObject screenToEnable;
        GameObject objectToEnable;
        if (percentage >= 0 && percentage < 10) 
        { //Fake NPC 1 Real ID - Appearance changed but still the real NPC
            Debug.Log("Fake NPC 1 Real ID");
            objectToEnable = IDSToEnable[npc];
            screenToEnable = ScreensToEnable[(npc * 3) + 1];
            screenToEnable.SetActive(true);
            objectToEnable.SetActive(true);
        }
        if (percentage >= 10 && percentage < 20) 
        { //Fake NPC 2 Real ID - Appearance changed but still the real NPC
            Debug.Log("Fake NPC 2 Real ID");
            objectToEnable = IDSToEnable[npc];
            screenToEnable = ScreensToEnable[(npc * 3) + 2];
            screenToEnable.SetActive(true);
            objectToEnable.SetActive(true);
        } 
        if (percentage >= 20 && percentage < 30) 
        { //Fake NPC 1 Fake ID - Appearance changed and is not the real NPC
            Debug.Log("Fake NPC 1 Fake ID");
            objectToEnable = FakeIDSToEnable[npc];
            screenToEnable = ScreensToEnable[(npc * 3) + 1];
            screenToEnable.SetActive(true);
            objectToEnable.SetActive(true);
        } 
        if (percentage >= 30 && percentage < 40) 
        { //Fake NPC 2 Fake ID - Appearance changed and is not the real NPC
            Debug.Log("Fake NPC 2 Fake ID");
            objectToEnable = FakeIDSToEnable[npc];
            screenToEnable = ScreensToEnable[(npc * 3) + 2];
            screenToEnable.SetActive(true);
            objectToEnable.SetActive(true);
        }    
        if (percentage >= 40 && percentage < 100) 
        { //Real Everything
            Debug.Log("Real Everything");
            objectToEnable = IDSToEnable[npc];
            screenToEnable = ScreensToEnable[npc * 3];
            screenToEnable.SetActive(true);
            objectToEnable.SetActive(true);
        }
        Debug.Log("NPC is: " + npc);
        introDialogue.SetActive(true);
    }

    public void hint() 
    {
        Instantiate(hintDialogue);
    }

    public void nameQuestion() 
    {
        GameObject[] options = new GameObject[0];
        if (npc == 0)
        {
            options = DialoguesToEnableNPC1;
        }
        if (npc == 1)
        {
            options = DialoguesToEnableNPC2;
        }
        if (npc == 2)
        {
            options = DialoguesToEnableNPC3;
        }
        if (percentage >= 0 && percentage < 10) 
        { //Fake NPC 1 Real ID
            Instantiate(options[0]); //tells real name
        }    
        if (percentage >= 10 && percentage < 20) 
        { //Fake NPC 2 Real ID
            Instantiate(options[0]); //tells real name
        } 
        if (percentage >= 20 && percentage < 30) 
        { //Fake NPC 1 Fake ID
            Instantiate(options[5]); //tells fake name variant 1
        } 
        if (percentage >= 30 && percentage < 40) 
        { //Fake NPC 2 Fake ID
            Instantiate(options[10]); //tells fake name variant 2
        }    
        if (percentage >= 40 && percentage < 100) 
        { //Real Everything
            Instantiate(options[0]); //tells real name
        }
    }    

    public void addyQuestion() 
    {
        GameObject[] options = new GameObject[0];
        if (npc == 0)
        {
            options = DialoguesToEnableNPC1;
        }
        if (npc == 1)
        {
            options = DialoguesToEnableNPC2;
        }
        if (npc == 2)
        {
            options = DialoguesToEnableNPC3;
        }
        if (percentage >= 0 && percentage < 10) 
        { //Fake NPC 1 Real ID
            Instantiate(options[1]); //tells real addy
        }    
        if (percentage >= 10 && percentage < 20) 
        { //Fake NPC 2 Real ID
            Instantiate(options[1]); //tells real addy
        } 
        if (percentage >= 20 && percentage < 30) 
        { //Fake NPC 1 Fake ID
            Instantiate(options[6]); //tells fake addy variant 1
        } 
        if (percentage >= 30 && percentage < 40) 
        { //Fake NPC 2 Fake ID
            Instantiate(options[11]); //tells fake addy variant 2
        }    
        if (percentage >= 40 && percentage < 100) 
        { //Real Everything
            Instantiate(options[1]); //tells real addy
        }
    }  

    public void genreQuestion() 
    {
        GameObject[] options = new GameObject[0];
        if (npc == 0)
        {
            options = DialoguesToEnableNPC1;
        }
        if (npc == 1)
        {
            options = DialoguesToEnableNPC2;
        }
        if (npc == 2)
        {
            options = DialoguesToEnableNPC3;
        }
        if (percentage >= 0 && percentage < 10) 
        { //Fake NPC 1 Real ID
            Instantiate(options[2]); //tells real genre
        }    
        if (percentage >= 10 && percentage < 20) 
        { //Fake NPC 2 Real ID
            Instantiate(options[2]); //tells real genre
        } 
        if (percentage >= 20 && percentage < 30) 
        { //Fake NPC 1 Fake ID
            Instantiate(options[7]); //tells fake genre variant 1
        } 
        if (percentage >= 30 && percentage < 40) 
        { //Fake NPC 2 Fake ID
            Instantiate(options[12]); //tells fake genre variant 2
        }    
        if (percentage >= 40 && percentage < 100) 
        { //Real Everything
            Instantiate(options[2]); //tells real genre
        }
    }  

    public void bookQuestion() 
    {
        GameObject[] options = new GameObject[0];
        if (npc == 0)
        {
            options = DialoguesToEnableNPC1;
        }
        if (npc == 1)
        {
            options = DialoguesToEnableNPC2;
        }
        if (npc == 2)
        {
            options = DialoguesToEnableNPC3;
        }
        if (percentage >= 0 && percentage < 10) 
        { //Fake NPC 1 Real ID
            Instantiate(options[3]); //tells real book
        }    
        if (percentage >= 10 && percentage < 20) 
        { //Fake NPC 2 Real ID
            Instantiate(options[3]); //tells real book
        } 
        if (percentage >= 20 && percentage < 30) 
        { //Fake NPC 1 Fake ID
            Instantiate(options[8]); //tells fake book variant 1
        } 
        if (percentage >= 30 && percentage < 40) 
        { //Fake NPC 2 Fake ID
            Instantiate(options[13]); //tells fake book variant 2
        }    
        if (percentage >= 40 && percentage < 100) 
        { //Real Everything
            Instantiate(options[3]); //tells real book
        }
    } 

    public void appearanceQuestion() 
    {
        GameObject[] options = new GameObject[0];
        if (npc == 0)
        {
            options = DialoguesToEnableNPC1;
        }
        if (npc == 1)
        {
            options = DialoguesToEnableNPC2;
        }
        if (npc == 2)
        {
            options = DialoguesToEnableNPC3;
        }
        if (percentage >= 0 && percentage < 10) 
        { //Fake NPC 1 Real ID
            Instantiate(options[4]); //tells real appearance
        }    
        if (percentage >= 10 && percentage < 20) 
        { //Fake NPC 2 Real ID
            Instantiate(options[4]); //tells real appearance
        } 
        if (percentage >= 20 && percentage < 30) 
        { //Fake NPC 1 Fake ID
            Instantiate(options[9]); //tells fake appearance variant 1
        } 
        if (percentage >= 30 && percentage < 40) 
        { //Fake NPC 2 Fake ID
            Instantiate(options[14]); //tells fake appearance variant 2
        }    
        if (percentage >= 40 && percentage < 100) 
        { //Real Everything
            Instantiate(options[4]); //tells real appearance
        }
    } 
}
