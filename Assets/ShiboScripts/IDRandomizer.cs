using System.Collections;
using System.Collections.Generic;
using Ink.Parsed;
using UnityEngine;

public class IDRandomizer : MonoBehaviour 
{
    public GameObject[] IDSToEnable;
    public GameObject[] FakeIDSToEnable;
    public GameObject[] ScreensToEnable;
    public GameObject[] NPCSToEnable;
    public GameObject NPC1Real;
    public GameObject NPC1Fake;
    public GameObject NPC2Real;
    public GameObject NPC2Fake;
    public GameObject NPC3Real;
    public GameObject NPC3Fake;
    int ind;
    int appind;
    int percentage;

    void Start()
    {
        percentage = Random.Range(0, 100);
        Debug.Log("Percent: " + percentage);
        if (IDSToEnable.Length > 0 && ScreensToEnable.Length > 0)
        {
            GameObject screenToEnable;
            GameObject npcToEnable;
            GameObject objectToEnable;
            if (percentage >= 0 && percentage < 15) { //All information is wrong
                ind = Random.Range(0, IDSToEnable.Length);
                int coinflip = Random.Range(0,2);
                if (coinflip == 0) {
                    objectToEnable = IDSToEnable[ind];
                } else {
                    objectToEnable = FakeIDSToEnable[ind];
                }
                ind = Random.Range(0, IDSToEnable.Length);
                npcToEnable = NPCSToEnable[ind];
                appind = Random.Range(0, IDSToEnable.Length);
                screenToEnable = ScreensToEnable[appind];
                npcToEnable.SetActive(true);
                screenToEnable.SetActive(true);
                objectToEnable.SetActive(true);
            }
            if (percentage >= 15 && percentage < 31) { //Same application and npc but wrong ID
                ind = Random.Range(0, IDSToEnable.Length);
                objectToEnable = FakeIDSToEnable[ind];  
                appind = Random.Range(0, IDSToEnable.Length);
                npcToEnable = NPCSToEnable[appind];
                screenToEnable = ScreensToEnable[appind];
                npcToEnable.SetActive(true);
                screenToEnable.SetActive(true);
                objectToEnable.SetActive(true);
            } 
            if (percentage >= 31 && percentage < 46) { //Same application and ID but wrong NPC
                appind = Random.Range(0, IDSToEnable.Length);
                objectToEnable = IDSToEnable[appind];
                screenToEnable = ScreensToEnable[appind];
                ind = Random.Range(0, IDSToEnable.Length);
                npcToEnable = NPCSToEnable[ind];
                npcToEnable.SetActive(true);
                screenToEnable.SetActive(true);
                objectToEnable.SetActive(true);
            } 
            if (percentage >= 46 && percentage < 100) { //Real npc
                appind = Random.Range(0, IDSToEnable.Length);
                screenToEnable = ScreensToEnable[appind];
                npcToEnable = NPCSToEnable[appind];
                objectToEnable = IDSToEnable[appind];
                npcToEnable.SetActive(true);
                screenToEnable.SetActive(true);
                objectToEnable.SetActive(true);
            }
        }
    }
    
    public void ActivateDialogue() {
        int i = Random.Range(0, 2);
        if (appind == 0) {
            if (i == 0) {
                Instantiate(NPC1Real);
            } else {
                Instantiate(NPC1Fake);
            }
        }
        if (appind == 1) {
            if (i == 0) {
                Instantiate(NPC2Real);
            } else {
                Instantiate(NPC2Fake);
            }
        }
        if (appind == 2) {
            if (i == 0) {
                Instantiate(NPC3Real);
            } else {
                Instantiate(NPC3Fake);
            }
        }
    }
}
