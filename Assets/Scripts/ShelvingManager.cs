using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelvingManager : MonoBehaviour
{
    public GameObject[] shelveOptions;

    private void Awake()
    {
        int randomShelves = Random.Range(0, shelveOptions.Length);
        shelveOptions[randomShelves].SetActive(true);
    }
}
