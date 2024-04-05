using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDRandomizer : MonoBehaviour 
{
    public GameObject[] IDSToEnable;
    public GameObject[] ScreensToEnable;
    public GameObject[] NPCSToEnable;

    void Start()
    {
        if (IDSToEnable.Length > 0 && ScreensToEnable.Length > 0)
        {
            int ind = Random.Range(0, IDSToEnable.Length);
            int ind2 = Random.Range(0, IDSToEnable.Length);
            GameObject objectToEnable = IDSToEnable[ind];
            GameObject screenToEnable = ScreensToEnable[ind];
            GameObject npcToEnable = NPCSToEnable[ind2];

            npcToEnable.SetActive(true);
            screenToEnable.SetActive(true);
            objectToEnable.SetActive(true);
        }
    }
}
